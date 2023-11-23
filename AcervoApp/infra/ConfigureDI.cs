using AcervoApp.view;
using AcervoDomain.entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Base;
using Repository.context;
using Repository.rep;
using Service.Base;
using Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.infra
{
    public static class ConfigureDI
    {

        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            Services.AddScoped<IBaseRepository<Tipo>, BaseRepository<Tipo>>();
            Services.AddScoped<IBaseService<Tipo>, BaseService<Tipo>>();

            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();

            Services.AddScoped<IBaseRepository<Favorito>, BaseRepository<Favorito>>();
            Services.AddScoped<IBaseService<Favorito>, BaseService<Favorito>>();

            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();

            Services.AddScoped<IBaseRepository<GeneroTipo>, BaseRepository<GeneroTipo>>();
            Services.AddScoped<IBaseService<GeneroTipo>, BaseService<GeneroTipo>>();

            Services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            Services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();

            // Formulários
            /*Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();*/

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Tipo, Tipo>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, Usuario>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Avaliacao, Avaliacao>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Favorito, Favorito>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Genero, Genero>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<GeneroTipo, GeneroTipo>(); }).CreateMapper());
            Services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Livro, Livro>(); }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
