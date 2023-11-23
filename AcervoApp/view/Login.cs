
using ReaLTaiizor.Forms;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bora cadastrar!!!");
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

        private void btnSemLogin_Click(object sender, EventArgs e)
        {
            //Entrar sem login
            new Principal().Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos solicitados!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                new Principal().Show();
            }
        }
    }
}
