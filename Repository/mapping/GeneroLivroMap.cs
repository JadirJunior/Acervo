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
    public class GeneroLivroMap : IEntityTypeConfiguration<AcervoDomain.entities.GeneroLivro>
    {
        public void Configure(EntityTypeBuilder<AcervoDomain.entities.GeneroLivro> builder)
        {
            builder.ToTable("GeneroLivro");

            builder.HasOne(prop => prop.Livro)
                .WithMany(prop => prop.Generos);

            builder.HasOne(prop => prop.Genero);

        }
    }
}
