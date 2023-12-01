using AcervoApp.models;
using AcervoApp.utils;
using ReaLTaiizor.Forms;
using Spire.Pdf;
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
    public partial class FormNovoLivro : MaterialForm
    {

        byte[] novaObra = null;
        byte[] thumbnail = null;

        public FormNovoLivro()
        {
            InitializeComponent();
            lstGeneros.Items.Add("Terror");
            lstGeneros.Items.Add("Romance");
            lstGeneros.Items.Add("Suspense");
            lstGeneros.Items.Add("Drama");
            lstGeneros.Items.Add("Comédia");
            lstGeneros.Items.Add("Aventura");
        }

        private void btnSelecionarPdf_Click(object sender, EventArgs e)
        {
            opfSelecionar.Filter = "Pdf Files|*.pdf";


            if (opfSelecionar.ShowDialog() == DialogResult.OK)
            {
                novaObra = File.ReadAllBytes(opfSelecionar.FileName);
                txtCaminho.Text = opfSelecionar.FileName;
            }

        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            opfSelecionar.Title = "Selecione uma imagem";
            opfSelecionar.Filter = "Imagens (*.ico;*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png;*.ico";

            if (opfSelecionar.ShowDialog() == DialogResult.OK)
            {
                thumbnail = File.ReadAllBytes(opfSelecionar.FileName);
                pcbImagem.Image = Image.FromFile(opfSelecionar.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Salvar um novo livro.

            List<GeneroModel> generos = new List<GeneroModel>();

            foreach (int a in lstGeneros.SelectedIndices)
            {
                generos.Add(new GeneroModel()
                {
                    Descricao = "Um gênero qualquer...",
                    Tipo = lstGeneros.Items[a].Text
                }) ;
            }

            StaticKeys.livros.Add(new LivroModel()
            {
                Autor = StaticKeys.usuarioLogado,
                Documento = novaObra,
                Titulo = txtTitulo.Text,
                Thumbnail = thumbnail,
                Sinopse = txtSinopse.Text,
                Generos = generos
            });


            MessageBox.Show("Livro salvo com sucesso!", "Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
