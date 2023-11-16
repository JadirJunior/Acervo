using AcervoDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.entities
{
    public class Tipo : BaseEntity<int>
    {

        public int? tipo;

        public Tipo() { }


        public Tipo(int tipo)
        {
            this.tipo = tipo;
        }

    }
}
