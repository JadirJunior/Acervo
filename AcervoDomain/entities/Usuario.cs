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
        public String? Bio;
        public List<Favorito> Favoritos;

        public Usuario() { }


        public Usuario(String nome, String user, String senha, String Bio, List<Favorito> favoritos)
        {
            this.Nome = nome;
            this.User = user;
            this.Senha = senha;
            this.Bio = Bio;
            this.Favoritos = favoritos;
        }

    }
}
