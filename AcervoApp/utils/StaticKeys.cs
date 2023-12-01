using AcervoApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.utils
{
    public static class StaticKeys
    {

        public static UsuarioModel? usuarioLogado = null;

        public static List<LivroModel> livros = new List<LivroModel>();

        public static List<LivroModel> favoritos = new List<LivroModel>();

    }
}
