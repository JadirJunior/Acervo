using AcervoDomain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.models
{
    public class LivroModel
    {

        public int Id { get; set; }

        public String? Titulo { get; set; }

        public String? Sinopse { get; set; }

        public byte[]? Thumbnail { get; set; }

        public byte[]? Documento { get; set; }

        public int usuarioId { get; set; }

        public Usuario? Autor { get; set; }

        public List<GeneroLivroModel>? Generos { get; set; }

        public  List<AvaliacaoModel>? Avaliacoes { get; set; }




    }
}
