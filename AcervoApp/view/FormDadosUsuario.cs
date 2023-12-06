using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;
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
    public partial class FormDadosUsuario : MaterialForm
    {
        public FormDadosUsuario()
        {
            InitializeComponent();
        }

        public FormDadosUsuario(Usuario usuario)
        {
            InitializeComponent();

            txtUser.Text = usuario.User;
            txtNome.Text = usuario.Nome;
            txtBio.Text = usuario.Bio;

            if (usuario.Imagem != null)
            {
                imagemUser.Image = Conversoes.BytesToImage(usuario.Imagem);
            }
        }
    }
}
