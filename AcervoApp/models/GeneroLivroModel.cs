using AcervoDomain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.models
{
    public class GeneroLivroModel
    {

        public int Id { get; set; }

        public int livroId { get; set; }

        public int generoId { get; set; }

        public Livro Livro { get; set; }

        public Genero Genero { get; set; }

    }
}
