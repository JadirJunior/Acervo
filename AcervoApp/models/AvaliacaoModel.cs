using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.models
{
    public class AvaliacaoModel
    {

        public int Id { get; set; }
        public String? Comentario { get; set; }
        public int Estrelas { get; set; }   

        public LivroModel? Livro { get; set; }

    }
}
