using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AcervoDomain.entities;
using Repository.mapping;

namespace Repository.context
{
    public class MySqlContext : DbContext
    {

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Livro>? Livro { get; set; }
        public DbSet<Favorito>? Favorito { get; set; }
        public DbSet<Genero>? Genero { get; set; }
        public DbSet<GeneroTipo>? GeneroTipo { get; set; }
        public DbSet<Tipo>? Tipo { get; set; }
        public DbSet<Avaliacao>? Avaliacao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
            modelBuilder.Entity<Favorito>(new FavoritoMap().Configure);
            modelBuilder.Entity<Genero>(new GeneroMap().Configure);
            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<Tipo>(new TipoMap().Configure);
            modelBuilder.Entity<GeneroTipo>(new GeneroTipoMap().Configure);
        }

    }
}
