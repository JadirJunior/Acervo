using AcervoApp.components;
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
    public partial class FormComentarios : MaterialForm
    {

        public static FormComentarios formComentarios;
        Livro livroModel;

        public void atualizarPagina()
        {
            if (livroModel.Avaliacoes != null )
            {
                foreach (var avaliacao in livroModel.Avaliacoes)
                {
                    panelComentarios.Controls.Add(new ComentarioItem(avaliacao));
                }
            }
            
        }


        public FormComentarios(Livro livro)
        {
            InitializeComponent();
            formComentarios = this;
            this.livroModel = livro;
            if (livro.Avaliacoes != null)
            {

                foreach (var avaliacao in livro.Avaliacoes)
                {
                    panelComentarios.Controls.Add(new ComentarioItem(avaliacao));
                }

            }

            if (livro.Autor != null && StaticKeys.usuarioLogado != null)
            {
                if (livro.Autor.Id == StaticKeys.usuarioLogado.Id)
                {
                    btnAvaliar.Visible = false;
                    btnAvaliar.Enabled = false;
                }
            }

            lblTitulo.Text = livro.Titulo;


        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            new FormAvaliar(livroModel).ShowDialog();
        }
    }
}
