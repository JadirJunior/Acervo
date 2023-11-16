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
    public class FavoritoMap : IEntityTypeConfiguration<Favorito>
    {
        public void Configure(EntityTypeBuilder<Favorito> builder)
        {
            builder.ToTable("Favorito");

            builder.HasKey(prop => prop.id);

            builder.HasOne(prop => prop.livro);

            builder.HasOne(prop => prop.usuario);
        }
    }
}
