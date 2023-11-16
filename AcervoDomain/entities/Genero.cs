using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Genero : BaseEntity<int>
    {

        public String? tipo;

        public String? descricao;

        public Genero() { }

        public Genero(String tipo, String descricao)
        {
            this.tipo = tipo;
            this.descricao = descricao;
        }


    }
}
