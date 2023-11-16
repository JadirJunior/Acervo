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

        public String? titulo;
        public String? sinopse;
        public byte[]? thumbnail;
        public byte[]? documento;
        public Usuario? autor;


        public Livro() { }

        public Livro(String titulo, String sinopse, byte[] documento, Usuario autor)
        {
            this.titulo = titulo;
            this.sinopse = sinopse;
            this.documento = documento;
            this.autor = autor;
        }

    }
}
