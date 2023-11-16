using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Usuario : BaseEntity<int>
    {

        public String? Nome;
        public String? User;
        public String? Senha;
        public byte[]? Imagem;
        public Tipo? tipo;
        public String? Bio;

        public Usuario() { }


        public Usuario(String nome, String user, String senha, Tipo tipo, String Bio)
        {
            this.Nome= nome;
            this.User= user;
            this.Senha= senha;
            this.tipo= tipo;
            this.Bio= Bio;
        }

    }
}
