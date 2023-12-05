using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Livro : BaseEntity<int>
    {

        public String? Titulo;
        public String? Sinopse;
        public byte[]? Thumbnail;
        public byte[]? Documento;
        public Usuario? Autor;
        public List<GeneroLivro> Generos;
        public List<Avaliacao> Avaliacoes;


        public Livro() { }

        public Livro(String titulo, String sinopse, byte[] documento, Usuario autor, List<GeneroLivro> generos, List<Avaliacao> avaliacoes)
        {
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Documento = documento;
            this.Autor = autor;
            this.Generos = generos;
            this.Avaliacoes = avaliacoes;
        }

    }
}
