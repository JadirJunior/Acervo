using AcervoApp.components;
using AcervoApp.infra;
using AcervoDomain.entities;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class Principal : MaterialForm
    {


        private void carregarObras()
        {
            panel.Controls.Clear();
            for (int i = 0; i < 15; i++)
            {
                
                panel.Controls.Add(new LivroItem());
            }
        }


        public Principal()
        {
            InitializeComponent();
            carregarObras();
        }

        
        private void tabHome_Enter(object sender, EventArgs e)
        {
            carregarObras();
        }

    }
}
