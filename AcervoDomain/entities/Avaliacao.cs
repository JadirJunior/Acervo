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

        public Usuario? Usuario;
        public String? Comentario;
        public int? Estrelas;
        public Livro? Livro;
        

        public Avaliacao() { }

        public Avaliacao(String comentario, int estrelas, Livro livro, Usuario usuario)
        {
            this.Comentario = comentario;
            this.Estrelas = estrelas;
            this.Livro = livro;
            this.Usuario = usuario;
        }
    }
}
