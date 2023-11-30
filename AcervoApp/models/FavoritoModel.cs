using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.models
{
    public class FavoritoModel
    {

        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public LivroModel Livro { get; set; }

    }
}
