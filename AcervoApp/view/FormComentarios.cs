using AcervoApp.components;
using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;
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
    public partial class FormComentarios : MaterialForm
    {

        public static FormComentarios formComentarios;
        public Livro livroModel;


        public readonly IBaseService<Avaliacao> _avaliacaoService;

        public void atualizarPagina()
        {
            panelComentarios.Controls.Clear();

            livroModel.Avaliacoes = _avaliacaoService.Get<Avaliacao>(new List<String> { "Livro", "Usuario" })
                    .Where(x => x.Livro!.Id == livroModel.Id).ToList();

            if (livroModel.Avaliacoes != null)
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

            _avaliacaoService = Principal.principal!._avaliacaoService;

            this.livroModel = livro;

            livroModel.Avaliacoes = _avaliacaoService.Get<Avaliacao>(new List<String> { "Livro", "Usuario" })
                    .Where(x => x.Livro!.Id == livroModel.Id).ToList();

            if (livro.Avaliacoes != null)
            {

                foreach (var avaliacao in livro.Avaliacoes)
                {
                    panelComentarios.Controls.Add(new ComentarioItem(avaliacao));
                }

            }

            if (livro.Autor != null && StaticKeys.usuarioEntity != null)
            {
                if (livro.Autor.Id == StaticKeys.usuarioEntity.Id)
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
