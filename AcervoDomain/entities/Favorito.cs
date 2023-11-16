using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Favorito : BaseEntity<int>
    {
        public Usuario? usuario;
        public Livro? livro;

        public Favorito() { }

        public Favorito(Usuario usuario, Livro livro)
        {
            this.usuario = usuario;
            this.livro = livro;
        }
    }
}
