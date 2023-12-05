
using AcervoApp.infra;
using AcervoApp.models;
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcervoApp.view
{
    public partial class Login : MaterialForm
    {


        public static Login login = null;
        private static bool fecharApp = true;

        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Favorito> _favoritoService;

        public Login()
        {
            InitializeComponent();
            _usuarioService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Usuario>>();
            _livroService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Livro>>();
            _favoritoService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Favorito>>();
            login = this;
            fecharApp = true;
        }

        public static void fecharLogin()
        {
            if (login != null)
            {
                fecharApp = false;
                login.Close();

            }
        }

        public static void fecharLogin(bool fechar)
        {
            if (login != null)
            {
                fecharApp = fechar;
                login.Close();

            }
        }

        private void checaUsuarios()
        {
            var usuarios = _usuarioService.Get<Usuario>(new List<String>() { "Favoritos" }).ToList();

            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Nome = "Jadir Junior",
                    User = "jadir",
                    Senha = "jadir",
                    Bio = "Um entusiasta de obras épicas",
                    Imagem = null,
                    Favoritos = new List<Favorito>()
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private Usuario? obterUsuario(String user, String senha)
        {
            checaUsuarios();

            var usuario = _usuarioService.Get<Usuario>(new List<String>() { "Favoritos" }).Where(x => x.User == user).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }

            return usuario.Senha != senha ? null : usuario; 
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            new CadastroUsuario().ShowDialog();
        }

        private void lblCadastro_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lblCadastro.ForeColor = Color.RoyalBlue;
            lblCadastro.Font = new Font(lblCadastro.Font.Name, lblCadastro.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblCadastro_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lblCadastro.ForeColor = Color.Black;
            lblCadastro.Font = new Font(lblCadastro.Font.Name, lblCadastro.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                Utils.messageExclamation("Preencha todos os campos solicitados!", "Login");
            }
            else
            {
                var usuario = obterUsuario(txtUser.Text, txtSenha.Text);

                if (usuario == null)
                {
                    Utils.messageExclamation("Credenciais inválidas!", "Login");
                } else
                {

                    StaticKeys.usuarioEntity = usuario;

                    foreach (var fav in usuario.Favoritos)
                    {

                        var favorito = _favoritoService.GetById<Favorito>(fav.Id, new List<String>() { "livro" });

                        var livro = _livroService.Get<Livro>().ToList().FirstOrDefault(x => x.Id == favorito.livro!.Id);
                        
                        if (livro != null)
                        {
                            StaticKeys.favoritos.Add(livro);
                        }

                    }


                    /*StaticKeys.usuarioLogado = new UsuarioModel()
                    {
                        Id = usuario.Id,
                        Nome = usuario.Nome!,
                        User = usuario.User!,
                        Senha = usuario.Senha!,
                        Bio = usuario.Bio!,
                        Imagem = usuario.Imagem!,
                        favoritos = 
                    };*/


                    if (Principal.principal == null)
                    {
                        new Principal().Show();
                    }
                    else
                    {
                        Principal.principal.Visible = true;

                        Principal.principal.carregarDados();
                    }

                    fecharLogin();
                }

                
            }
        }

        private void btnEntrar2_Click(object sender, EventArgs e)
        {

            if (Principal.principal == null)
            {
                new Principal().Show();
            }
            else
            {
                Principal.principal.Visible = true;
                Principal.principal.carregarDados();
            }
            fecharLogin();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fecharApp)
            {
                if (Principal.principal != null)
                {
                    Principal.principal.logout = false;
                }
                Application.Exit();
            }
        }
    }
}
