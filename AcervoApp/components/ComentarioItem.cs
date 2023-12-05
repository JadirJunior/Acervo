using AcervoApp.models;
using AcervoApp.Properties;
using AcervoApp.utils;
using AcervoDomain.entities;
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
    public partial class ComentarioItem : UserControl
    {


        Avaliacao avaliacao;

        public ComentarioItem()
        {
            InitializeComponent();
        }


        public ComentarioItem(Avaliacao avaliacao)
        {
            InitializeComponent();
            this.avaliacao = avaliacao;
            if (avaliacao.Usuario != null)
            {
                pcbUser.Image = Conversoes.BytesToImage(avaliacao.Usuario.Imagem);
                lblUser.Text = avaliacao.Usuario.User;
            }


            txtComentario.Text = avaliacao.Comentario;

            star1.Image = avaliacao.Estrelas >= 1 ? Resources.starIcon : Resources.emptyStar;
            star2.Image = avaliacao.Estrelas >= 2 ? Resources.starIcon : Resources.emptyStar;
            star3.Image = avaliacao.Estrelas >= 3 ? Resources.starIcon : Resources.emptyStar;
            star4.Image = avaliacao.Estrelas >= 4 ? Resources.starIcon : Resources.emptyStar;
            star5.Image = avaliacao.Estrelas == 5 ? Resources.starIcon : Resources.emptyStar;
        }
    }
}
