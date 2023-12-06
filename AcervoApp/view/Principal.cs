using AcervoApp.components;
using AcervoApp.infra;
using AcervoApp.models;
using AcervoApp.Properties;
using AcervoApp.utils;
using AcervoDomain.entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
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
    public partial class Principal : MaterialForm
    {

        public bool logout = false;

        public readonly IBaseService<Livro> _livroService;
        public readonly IBaseService<Usuario> _usuarioService;
        public readonly IBaseService<Favorito> _favoritoService;
        public readonly IBaseService<GeneroLivro> _generoLivroService;
        public readonly IBaseService<Genero> _generoService;
        public readonly IBaseService<Avaliacao> _avaliacaoService;


        public static Principal? principal;
        public int contagemId = 0;


        public void carregarObras()
        {
            panel.Controls.Clear();

            foreach (var livro in _livroService.Get<Livro>(new List<String> { "Generos", "Autor", "Avaliacoes" }).ToList())
            {
                panel.Controls.Add(new LivroItem(livro));
            }


        }

        public void carregarFavoritos()
        {
            panelFav.Controls.Clear();

            foreach (var favorito in _favoritoService.Get<Favorito>(new List<String> { "livro", "usuario" }).ToList().Where(x => x.usuario!.Id == StaticKeys.usuarioEntity!.Id))
            {
                var livro = _livroService.GetById<Livro>(favorito.livro!.Id, new List<String> { "Generos", "Autor", "Avaliacoes" });
                panelFav.Controls.Add(new LivroItem(livro));
            }

        }

        private void resetarCampos()
        {
            txtNome.Text = StaticKeys.usuarioEntity!.Nome;
            txtBio.Text = StaticKeys.usuarioEntity.Bio;
            txtUser.Text = StaticKeys.usuarioEntity.User;
            txtSenha.Text = StaticKeys.usuarioEntity.Senha;

            if (StaticKeys.usuarioEntity.Imagem != null)
            {
                imagemUser.Image = Conversoes.BytesToImage(StaticKeys.usuarioEntity.Imagem);
            }
            else
            {
                imagemUser.Image = Resources.UserIcon;
            }
        }

        public void carregarDados()
        {
            pages.SelectedIndex = 0;
            principal = this;
            logout = false;
            carregarObras();
        }

        public Principal()
        {
            InitializeComponent();
            _generoLivroService = ConfigureDI.ServicesProvider!.GetService<IBaseService<GeneroLivro>>()!;
            _livroService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Livro>>()!;
            _usuarioService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Usuario>>()!;
            _favoritoService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Favorito>>()!;
            _generoService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Genero>>()!;
            _avaliacaoService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Avaliacao>>()!;
            carregarDados();
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
            if (StaticKeys.usuarioEntity != null)
            {
                StaticKeys.usuarioEntity.Nome = txtNome.Text;
                StaticKeys.usuarioEntity.User = txtUser.Text;
                StaticKeys.usuarioEntity.Senha = txtSenha.Text;
                StaticKeys.usuarioEntity.Bio = txtBio.Text;
                StaticKeys.usuarioEntity.Imagem = Conversoes.ImageToBytes(imagemUser.Image);

                _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(StaticKeys.usuarioEntity);



                Utils.messageBoxOk("Perfil salvo com sucesso!", "Usuário");
            }
        }

        private void tabUser_Enter(object sender, EventArgs e)
        {
            if (StaticKeys.usuarioEntity != null)
            {
                resetarCampos();
            }

        }

        private void cmbMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbMostraSenha.Checked)
            {
                txtSenha.PasswordChar = default;
            }
            else
            {
                txtSenha.PasswordChar = '*';
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

        private void tabLoggout_Click(object sender, EventArgs e)
        {

        }

        private void tabLoggout_Enter(object sender, EventArgs e)
        {
            StaticKeys.reset();
            this.logout = true;
            new Login().Show();

            this.Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
