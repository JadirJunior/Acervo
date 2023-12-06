using AcervoApp.models;
using AcervoApp.Properties;
using AcervoApp.utils;
using AcervoDomain.entities;
using MaterialSkin.Controls;
using ReaLTaiizor.Controls;
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
    public partial class FormAvaliar : MaterialForm
    {

        List<ForeverButton> stars = new List<ForeverButton>();
        List<ForeverButton> selectedStars = new List<ForeverButton>();
        Livro livro;

        public readonly IBaseService<Avaliacao> _avaliacaoService;

        public FormAvaliar(Livro livro)
        {
            InitializeComponent();
            this.livro = livro;
            stars.Add(btnStar1);
            stars.Add(btnStar2);
            stars.Add(btnStar3);
            stars.Add(btnStar4);
            stars.Add(btnStar5);

            _avaliacaoService = Principal.principal!._avaliacaoService;

        }

        private void selecionarEstrelas(int numEstrelas)
        {
            int cont = 0;

            selectedStars.Clear();

            foreach (var button in stars)
            {

                if (cont < numEstrelas)
                {
                    button.BackgroundImage = Resources.starIcon;
                    selectedStars.Add(button);
                }

                else
                {
                    button.BackgroundImage = Resources.emptyStar;
                    selectedStars.Remove(button);
                }
                cont++;
            }
        }

        private void btnStar1_Click(object sender, EventArgs e)
        {
            if (selectedStars.Contains(btnStar1))
            {
                selecionarEstrelas(0);
            }
            else
            {
                selecionarEstrelas(1);
            }
        }

        private void btnStar2_Click(object sender, EventArgs e)
        {
            if (selectedStars.Contains(btnStar2))
            {
                selecionarEstrelas(1);
            }
            else
            {
                selecionarEstrelas(2);
            }
        }

        private void btnStar3_Click(object sender, EventArgs e)
        {
            if (selectedStars.Contains(btnStar3))
            {
                selecionarEstrelas(2);
            }
            else
            {
                selecionarEstrelas(3);
            }
        }

        private void btnStar4_Click(object sender, EventArgs e)
        {
            if (selectedStars.Contains(btnStar4))
            {
                selecionarEstrelas(3);
            }
            else
            {
                selecionarEstrelas(4);
            }
        }

        private void btnStar5_Click(object sender, EventArgs e)
        {
            if (selectedStars.Contains(btnStar5))
            {
                selecionarEstrelas(4);
            }
            else
            {
                selecionarEstrelas(5);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacaoModel = new Avaliacao()
            {
                Livro = livro,
                Comentario = txtComentario.Text,
                Estrelas = selectedStars.Count,
                Usuario = StaticKeys.usuarioEntity
            };

            var avaliado = StaticKeys.livros.FirstOrDefault(x => x.Id == livro.Id);

            Avaliacao Av = _avaliacaoService.Add<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacaoModel);

            FormComentarios.formComentarios.livroModel.Avaliacoes.Add(Av);

            FormComentarios.formComentarios.atualizarPagina();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
