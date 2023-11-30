using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String User { get; set; }

        public String Senha { get; set; }

        public byte[] Imagem { get; set; }

        public TipoModel Tipo { get; set; }

        public String Bio { get; set; }
    }
}
