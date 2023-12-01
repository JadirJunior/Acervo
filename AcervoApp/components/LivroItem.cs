using AcervoApp.models;
using AcervoApp.Properties;
using AcervoApp.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcervoApp.components
{
    public partial class LivroItem : UserControl
    {

        private bool vazio = true;

        private LivroModel livroModel;

        public LivroItem()
        {
            InitializeComponent();
        }

        public LivroItem(LivroModel livro)
        {
            InitializeComponent();
            livroModel = livro;

            lblTitulo.Text = livro.Titulo;
            txtSinopse.Text = livro.Sinopse;

            if (livro.Autor != null &&  livro.Autor.Imagem != null)
            {
                imagemUser.Image = Conversoes.BytesToImage(livro.Autor.Imagem);
            }

            foreach (GeneroModel model in livro.Generos)
            {
                listGeneros.Items.Add(model.Tipo);
            }

            var ret = StaticKeys.favoritos.Find(x => x.Id == livro.Id);

            if (ret != null)
            {
                vazio = false;
                pcbFavorito.Image = Resources.CoracaoCheio;
            }
        }

        private void LivroItem_Load(object sender, EventArgs e)
        {

        }

        private void imagemUser_Click(object sender, EventArgs e)
        {

        }

        private void LivroItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriu um livro novo!!");
        }

        private void imagemUser_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void imagemUser_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void pcbFavorito_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                pcbFavorito.Image = Resources.CoracaoCheio;
                StaticKeys.favoritos.Add(livroModel);

            } else
            {
                pcbFavorito.Image = Resources.CoracaoVazio;
                var item = StaticKeys.favoritos.FirstOrDefault(x => x.Id == livroModel.Id);
                if (item != null)
                {
                    StaticKeys.favoritos.Remove(item);
                }
            }

            vazio = !vazio;
        }
    }
}
