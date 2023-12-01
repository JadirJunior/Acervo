using AcervoApp.models;
using AcervoApp.utils;
using MaterialSkin.Controls;
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

        public CadastroUsuario()
        {
            InitializeComponent();
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
                    Utils.messageBoxOk("Usuário Cadastrado com sucesso!", "Cadastro");

                    StaticKeys.usuarioLogado = new UsuarioModel()
                    {

                        Nome = txtNome.Text,
                        User = txtUser.Text,
                        Senha = txtSenha.Text,
                        Bio = txtBio.Text,
                        Imagem = imageBytes,
                        Tipo = new TipoModel()
                        {
                            Tipo = 0
                        }

                    };
                }
                 
                
            }

            


            new Principal().Show();
            Login.fecharLogin(false);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
