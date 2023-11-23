using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AcervoDomain.Base
{
    public abstract class BaseEntity<IId> : IBaseEntity
    {

        public BaseEntity() { }

        protected BaseEntity(IId id)
        {
            Id = id;
        }

        public virtual IId? Id { get; set; }
    }
}