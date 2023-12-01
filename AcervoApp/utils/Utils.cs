using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.utils
{
    public class Utils
    {

        public static void messageBoxOk(String texto, String titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void messageExclamation(String texto, String titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
