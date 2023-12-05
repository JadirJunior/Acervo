using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class GeneroLivro : BaseEntity<int>
    {

        public Livro? Livro;
        public Genero? Genero;

        public GeneroLivro() { }

        public GeneroLivro(Livro livro, Genero genero)
        {
            this.Livro = livro;
            this.Genero = genero;
        }

    }
}
