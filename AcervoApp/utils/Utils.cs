using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.utils
{
    public class Utils
    {

        public static DialogResult messageBoxOk(String texto, String titulo)
        {
            return MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult messageExclamation(String texto, String titulo)
        {
            return MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult messageQuestion(String texto, String titulo)
        {
            return MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
