using AcervoApp.infra;
using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using Service.Base;
using Service.validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcervoApp.view
{
    public partial class CadastroUsuario : MaterialForm
    {

        byte[] imageBytes = null;

        private readonly IBaseService<Usuario> _usuarioService; 

        public CadastroUsuario()
        {
            InitializeComponent();
            _usuarioService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Usuario>>();
        }

        private bool usuarioExiste(String user)
        {
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.User == user).FirstOrDefault();
            if (usuario == null)
            {
                return false;
            }

            return true;
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            opfImagem.Title = "Selecione uma imagem";
            opfImagem.Filter = "Imagens (*.ico;*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png;*.ico";

            if (opfImagem.ShowDialog() == DialogResult.OK)
            {
                imageBytes = File.ReadAllBytes(opfImagem.FileName);
                pcbImagem.Image = Image.FromFile(opfImagem.FileName);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (
                String.IsNullOrEmpty(txtNome.Text) ||
                String.IsNullOrEmpty(txtUser.Text) ||
                String.IsNullOrEmpty(txtSenha.Text) ||
                String.IsNullOrEmpty(txtBio.Text) )
            {
                Utils.messageExclamation("Preencha todos os campos!", "Cadastro");
            } else
            {
                if (txtSenha.Text != txtSenhaConf.Text)
                {
                    Utils.messageExclamation("Senhas não coincidentes!", "Cadastro");
                } 
                
                else
                
                {
                    
                    if (usuarioExiste(txtUser.Text))
                    {
                        Utils.messageExclamation("Usuário já cadastrado!", "Cadastro");

                    } else
                    {
                        var usuario = new Usuario()
                        {

                            Nome = txtNome.Text,
                            User = txtUser.Text,
                            Senha = txtSenha.Text,
                            Bio = txtBio.Text,
                            Imagem = imageBytes

                        };



                        Usuario novoUsuario = _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

                        StaticKeys.usuarioLogado = new UsuarioModel()
                        {
                            Id = novoUsuario.Id,
                            Nome = txtNome.Text,
                            User = txtUser.Text,
                            Senha = txtSenha.Text,
                            Bio = txtBio.Text,
                            Imagem = imageBytes

                        };

                        StaticKeys.usuarioEntity = novoUsuario;

                        Utils.messageBoxOk("Usuário Cadastrado com sucesso!", "Cadastro");

                        new Principal().Show();
                        Login.fecharLogin(false);
                    }

                    

                }


            }

            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
