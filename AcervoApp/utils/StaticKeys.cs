using AcervoApp.models;
using AcervoDomain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.utils
{
    public static class StaticKeys
    {

        public static Usuario? usuarioEntity = null;

        public static UsuarioModel? usuarioLogado = null;

        public static List<Livro> livros = new List<Livro>();

        public static List<Livro> favoritos = new List<Livro>();

        public static void reset()
        {
            usuarioEntity = null;
            usuarioLogado = null;
            livros = new List<Livro>();
            favoritos = new List<Livro>();
        }

    }
}
