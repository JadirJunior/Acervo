using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class GeneroTipo : BaseEntity<int>
    {

        public Livro? livro;
        public Genero? genero;

        public GeneroTipo() { }

        public GeneroTipo(Livro livro, Genero genero)
        {
            this.livro= livro;
            this.genero= genero;
        }


    }
}
