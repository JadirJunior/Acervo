using AcervoApp.models;
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
using Service.validators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.infra
{
    public static class ConfigureDI
    {

        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        private static void configuraGeneros()
        {
            var _generoService = ServicesProvider!.GetService<IBaseService<Genero>>();

            var generos = _generoService!.Get<GeneroModel>().ToList();

            if (!generos.Any())
            {
                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Terror",
                    descricao = "Histórias assustadoras e eletrizantes"
                });

                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Comédia",
                    descricao = "Histórias divertidas e engraçadas"
                });

                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Ação",
                    descricao = "Histórias cheias de ação e muito frenéticas"
                });

                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Aventura",
                    descricao = "Histórias cheias de aventuras e mistérios para descobrir!"
                });

                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Romance",
                    descricao = "Histórias para fazer com que se emocione em meio à paixão!"
                });

                _generoService.Add<Genero, Genero, GeneroValidator>(new Genero()
                {
                    tipo = "Científico",
                    descricao = "Pesquisas, conceitos e amostragens científicas"
                });
            }
        }

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                //var strCon = File.ReadAllText("C:\\Users\\jadir\\source\\repos\\Acervo\\AcervoApp\\config\\DatabaseSettings.txt");
                var strCon = File.ReadAllText("..\\..\\..\\config\\DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();

            Services.AddScoped<IBaseRepository<Favorito>, BaseRepository<Favorito>>();
            Services.AddScoped<IBaseService<Favorito>, BaseService<Favorito>>();

            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();

            Services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            Services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();

            Services.AddScoped<IBaseRepository<GeneroLivro>, BaseRepository<GeneroLivro>>();
            Services.AddScoped<IBaseService<GeneroLivro>, BaseService<GeneroLivro>>();

            // Formulários
            /*Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<FormNovoLivro, FormNovoLivro>();
            Services.AddTransient<FormAvaliar, FormAvaliar>();
            Services.AddTransient<FormComentarios, FormComentarios>();
            Services.AddTransient<FormDadosLivro, FormDadosLivro>();*/

            // Mapping

            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x!.Id}"))
                    .ForMember(d => d.User, d => d.MapFrom(x => $"{x!.User}"))
                    .ForMember(d => d.Senha, d => d.MapFrom(x => $"{x.Senha}"))
                    .ForMember(d => d.Bio, d => d.MapFrom(x => $"{x.Bio}"))
                    .ForMember(d => d.Nome, d => d.MapFrom(x => $"{x.Nome}"))
                    .ForMember(d => d.Imagem, d => d.MapFrom(x => $"{x.Imagem}"))
                    .ForMember(d => d.favoritos, d => d.MapFrom(x => $"{x.Favoritos}"));



                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x!.Id}"))
                    .ForMember(d => d.usuarioId, d => d.MapFrom(x => $"{x.Usuario!.Id}"))
                    .ForMember(d => d.livroId, d => d.MapFrom(x => $"{x.Livro!.Id}"))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => $"{x.Usuario}"))
                    .ForMember(d => d.Comentario, d => d.MapFrom(x => $"{x.Comentario}"))
                    .ForMember(d => d.Estrelas, d => d.MapFrom(x => $"{x.Estrelas}"))
                    .ForMember(d => d.Livro, d => d.MapFrom(x => $"{x.Livro}"));



                config.CreateMap<Favorito, FavoritoModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x!.Id}"))
                    .ForMember(d => d.usuarioId, d => d.MapFrom(x => $"{x.usuario!.Id}"))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => $"{x.usuario}"))
                    .ForMember(d => d.livroId, d => d.MapFrom(x => $"{x.livro!.Id}"))
                    .ForMember(d => d.Livro, d => d.MapFrom(x => $"{x.livro}"));


                config.CreateMap<Genero, GeneroModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x!.Id}"))
                    .ForMember(d => d.Descricao, d => d.MapFrom(x => $"{x.descricao}"))
                    .ForMember(d => d.Tipo, d => d.MapFrom(x => $"{x.tipo}"));
                
                
                
                config.CreateMap<Livro, LivroModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x!.Id}"))
                    .ForMember(d => d.usuarioId, d => d.MapFrom(x => $"{x.Autor!.Id}"))
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => $"{x.Titulo}"))
                    .ForMember(d => d.Avaliacoes, d => d.MapFrom(x => $"{x.Avaliacoes}"))
                    .ForMember(d => d.Documento, d => d.MapFrom(x => $"{x.Documento}"))
                    .ForMember(d => d.Sinopse, d => d.MapFrom(x => $"{x.Sinopse}"))
                    .ForMember(d => d.Thumbnail, d => d.MapFrom(x => $"{x.Thumbnail}"))
                    .ForMember(d => d.Generos, d => d.MapFrom(x => $"{x.Generos}"))
                    .ForMember(d => d.Autor, d => d.MapFrom(x => $"{x.Autor}"));
                
                
                config.CreateMap<GeneroLivro, GeneroLivroModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => $"{x.Id}"))
                    .ForMember(d => d.livroId, d => d.MapFrom(x => $"{x.Livro!.Id}"))
                    .ForMember(d => d.generoId, d => d.MapFrom(x => $"{x.Genero!.Id}"))
                    .ForMember(d => d.tipoGenero, d => d.MapFrom(x => $"{x.Genero!.tipo}"));
            }).CreateMapper());


            ServicesProvider = Services.BuildServiceProvider();

            configuraGeneros();
        }

    }
}
