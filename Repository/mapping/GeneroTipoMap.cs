using AcervoDomain.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.mapping
{
    public class GeneroTipoMap : IEntityTypeConfiguration<GeneroTipo>
    {
        public void Configure(EntityTypeBuilder<GeneroTipo> builder)
        {
            builder.ToTable("GeneroTipo");

            builder.HasOne(prop => prop.livro);

            builder.HasOne(prop => prop.genero);

        }
    }
}
