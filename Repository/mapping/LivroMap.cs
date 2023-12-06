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

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(70)");

            builder.Property(prop => prop.Sinopse)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.Documento)
                .IsRequired()
                .HasColumnType("longblob");

            builder.Property(prop => prop.Thumbnail)
                .IsRequired()
                .HasColumnType("longblob");

            builder.HasOne(prop => prop.Autor);

            builder.HasMany(prop => prop.Generos)
                .WithOne(prop => prop.Livro);

            builder.HasMany(prop => prop.Avaliacoes)
                .WithOne(prop => prop.Livro);

        }
    }
}
