using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;

namespace AcervoApp.view
{
    public partial class FormDadosLivro : MaterialForm
    {

        PdfViewer pdf;

        public FormDadosLivro(Livro livroModel)
        {
            InitializeComponent();
            pdf = new PdfViewer();

            if (livroModel != null && livroModel.Documento != null)
            {
                pdf.Document = Conversoes.BytesToPdf(livroModel.Documento);
            }

            pdf.Width = panelPdf.Width - 20;
            pdf.Height = panelPdf.Height - 20;

            panelPdf.Controls.Add(pdf);
        }

        private void FormDadosLivro_Resize(object sender, EventArgs e)
        {
            pdf.Width = panelPdf.Width - 20;
            pdf.Height = panelPdf.Height - 20;
        }
    }
}
