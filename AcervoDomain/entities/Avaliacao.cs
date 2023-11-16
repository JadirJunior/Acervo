using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Avaliacao : BaseEntity<int>
    {
            
        public String? comentario;
        public int? estrelas;
        public Livro? livro;
        

        public Avaliacao() { }

        public Avaliacao(String comentario, int estrelas, Livro livro)
        {
            this.comentario = comentario;
            this.estrelas = estrelas;
            this.livro = livro;
        }
    }
}
