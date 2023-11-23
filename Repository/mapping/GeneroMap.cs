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
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.descricao)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.descricao)
                .IsRequired()
                .HasColumnType("varchar(255)");

        }
    }
}
