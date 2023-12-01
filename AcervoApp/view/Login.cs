
using AcervoApp.models;
using AcervoApp.utils;
using ReaLTaiizor.Forms;
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

        public Login()
        {
            InitializeComponent();
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
                StaticKeys.usuarioLogado = new UsuarioModel()
                {
                    Id = 1,
                    Nome = "Jadir Pires de Borba Junior",
                    User = "@jadirjunior8",
                    Senha = "SenhaDaora",
                    Imagem = null,
                    Bio = "A vida já cansou, to morto demais",

                    Tipo = new TipoModel()
                    {
                        Id = 1,
                        Tipo = 0
                    }
                };

                new Principal().Show();
                fecharLogin();
            }
        }

        private void btnEntrar2_Click(object sender, EventArgs e)
        {

            new Principal().Show();
            fecharLogin();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fecharApp)
            {
                Application.Exit();
            }
        }
    }
}
