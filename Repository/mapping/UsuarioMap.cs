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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.User)
                .IsRequired()
                .HasColumnType("varchar(35)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(35)");

            builder.Property(prop => prop.Bio)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.Imagem)
                .HasColumnType("blob");

            builder.HasOne(prop => prop.tipo);



        }
    }
}
