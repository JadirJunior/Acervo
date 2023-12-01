using AcervoApp.components;
using AcervoApp.infra;
using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using Service.Base;
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
    public partial class Principal : MaterialForm
    {


        private void carregarObras()
        {
            panel.Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                panel.Controls.Add(new LivroItem(new LivroModel()
                {
                    Id = i,
                    Documento = null,
                    Generos = new List<GeneroModel>(),
                    Sinopse = "Livro daora",
                    Thumbnail = null,
                    Titulo = "Título legal",

                    Autor = new UsuarioModel()
                    {
                        Id = 2,
                        Nome = "Roberto",
                        User = "@robertinho02",
                        Imagem = null,
                        Bio = "Bio Daora do carinha."
                    }


                }));
            }

            foreach (LivroModel model in StaticKeys.livros)
            {
                panel.Controls.Add(new LivroItem(model));
            }


        }

        private void carregarFavoritos()
        {
            panelFav.Controls.Clear();

            foreach (LivroModel model in StaticKeys.favoritos)
            {
                panelFav.Controls.Add(new LivroItem(model));
            }

        }

        private void resetarCampos()
        {
            txtNome.Text = StaticKeys.usuarioLogado.Nome;
            txtBio.Text = StaticKeys.usuarioLogado.Bio;
            txtUser.Text = StaticKeys.usuarioLogado.User;
            txtSenha.Text = StaticKeys.usuarioLogado.Senha;

            if (StaticKeys.usuarioLogado.Imagem != null)
            {
                //Carregue a imagem!
                imagemUser.Image = Conversoes.BytesToImage(StaticKeys.usuarioLogado.Imagem);
            }
        }


        public Principal()
        {
            InitializeComponent();
            if (StaticKeys.usuarioLogado == null)
            {
                pages.Controls.Remove(tabUser);
                pages.Controls.Remove(tabFavoritos);
            }
            carregarObras();
        }


        private void tabHome_Enter(object sender, EventArgs e)
        {
            carregarObras();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StaticKeys.usuarioLogado != null)
            {
                StaticKeys.usuarioLogado.Nome = txtNome.Text;
                StaticKeys.usuarioLogado.User = txtUser.Text;
                StaticKeys.usuarioLogado.Senha = txtSenha.Text;
                StaticKeys.usuarioLogado.Bio = txtBio.Text;
                StaticKeys.usuarioLogado.Imagem = Conversoes.ImageToBytes(imagemUser.Image);
                //Fazer o salvamento da imagem
                Utils.messageBoxOk("Perfil salvo com sucesso!", "Usuário");
            }
        }

        private void tabUser_Enter(object sender, EventArgs e)
        {
            if (StaticKeys.usuarioLogado != null)
            {
                resetarCampos();
            }

        }

        private void cmbMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbMostraSenha.Checked)
            {
                txtSenha.PasswordChar = default;
                //txtSenha.Text = StaticKeys.usuarioLogado.Senha;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                //txtSenha.Text = StaticKeys.usuarioLogado.Senha;
            }
        }

        private void tabFavoritos_Enter(object sender, EventArgs e)
        {
            carregarFavoritos();
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            new FormNovoLivro().ShowDialog();
        }

        private void imagemUser_DoubleClick(object sender, EventArgs e)
        {
            opfUser.Title = "Selecione uma imagem";
            opfUser.Filter = "Imagens (*.ico;*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png;*.ico";

            if (opfUser.ShowDialog() == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(opfUser.FileName);
                imagemUser.Image = Image.FromFile(opfUser.FileName);
            }
        }
    }
}
