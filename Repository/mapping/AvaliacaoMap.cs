using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcervoDomain.entities;

namespace Repository.mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.comentario)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.estrelas)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne(prop => prop.livro);

        }
    }
}
