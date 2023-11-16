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
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(prop => prop.id);

            builder.Property(prop => prop.titulo)
                .IsRequired()
                .HasColumnType("varchar(70)");

            builder.Property(prop => prop.sinopse)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.documento)
                .IsRequired()
                .HasColumnType("blob");

            builder.Property(prop => prop.thumbnail)
                .IsRequired()
                .HasColumnType("blob");

            builder.HasOne(prop => prop.autor);


        }
    }
}
