using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repository.Base;
using Repository.context;
using AcervoDomain.entities;
using Service.Base;
using Service.services;
using Repository.rep;
using Service.validators;
using System.Text.Json;

namespace Test
{
    [TestClass]
    public class UnitTestService
    {

        private ServiceCollection? services;


        [TestMethod]
        public void TestTipo()
        {

            var sp = ConfiguraServices();
            var tipoService = sp.GetService<IBaseService<Tipo>>();

            var tipo = new Tipo
            {
                tipo = 1
            };


            var result = tipoService?.Add<Tipo, Tipo, TipoValidator>(tipo);



            Console.WriteLine(JsonSerializer.Serialize(result));

        }


        [TestMethod]
        public void TestInserirUsuario()
        {

            var sp = ConfiguraServices();
            var tipoService = sp.GetService<IBaseService<Tipo>>();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();


            var usuario = new Usuario
            {
                Nome = "Jadir",
                User = "Macaco06",
                Senha = "12345",
                Bio = "Alguém com um grande objetivo de fazer nada.",
                Imagem = null,
                tipo = tipoService?.GetById<Tipo>(1)
            };



            var result = usuarioService?.Add<Usuario, Usuario, UsuarioValidator>(usuario);



            Console.WriteLine(JsonSerializer.Serialize(result));

        }

        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "Acervo";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Tipo>, BaseRepository<Tipo>>();
            services.AddScoped<IBaseService<Tipo>, BaseService<Tipo>>();

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();

            services.AddScoped<IBaseRepository<Favorito>, BaseRepository<Favorito>>();
            services.AddScoped<IBaseService<Favorito>, BaseService<Favorito>>();

            services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();

            services.AddScoped<IBaseRepository<GeneroTipo>, BaseRepository<GeneroTipo>>();
            services.AddScoped<IBaseService<GeneroTipo>, BaseService<GeneroTipo>>();

            services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();


            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Tipo, Tipo>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, Usuario>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Avaliacao, Avaliacao>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Favorito, Favorito>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Genero, Genero>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<GeneroTipo, GeneroTipo>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Livro, Livro>(); }).CreateMapper());

            return services.BuildServiceProvider();
        }
    }
}