using AcervoApp.infra;
using AcervoApp.models;
using AcervoApp.Properties;
using AcervoApp.utils;
using AcervoApp.view;
using AcervoDomain.entities;
using Microsoft.Extensions.DependencyInjection;
using Service.Base;
using Service.validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcervoApp.components
{
    public partial class LivroItem : UserControl
    {

        private bool vazio = true;

        private Livro livroModel;


        private readonly IBaseService<GeneroLivro> _generoLivroService;
        private readonly IBaseService<Favorito> _favoritosService;
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Avaliacao> _avaliacaoService;

        public LivroItem(Livro livro)
        {
            InitializeComponent();
            livroModel = livro;
            _generoLivroService = Principal.principal!._generoLivroService;
            _favoritosService = Principal.principal._favoritoService;
            _livroService = Principal.principal._livroService;
            _avaliacaoService = Principal.principal._avaliacaoService;



            var ret = StaticKeys.favoritos.Find(x => x.Id == livro.Id);

            if (ret != null)
            {
                vazio = false;
                pcbFavorito.Image = Resources.CoracaoCheio;
            }

            if (livroModel.Autor?.Id != StaticKeys.usuarioEntity?.Id)
            {
                pcbApagar.Enabled = false;
                pcbApagar.Visible = false;
                pcbEditar.Enabled = false;
                pcbEditar.Visible = false;
            }

            lblTitulo.Text = livro.Titulo;
            txtSinopse.Text = livro.Sinopse;
            lblUser.Text = "Autor: " + livroModel.Autor!.User;

            if (livro.Autor != null && livro.Autor.Imagem != null)
            {
                imagemUser.Image = Conversoes.BytesToImage(livro.Autor.Imagem);
            }
            else
            {
                imagemUser.Image = Resources.UserIcon;
            }

            foreach (GeneroLivro model in livro.Generos)
            {

                listGeneros.Items.Add(_generoLivroService.GetById<GeneroLivro>(model.Id, new List<String>() { "Genero" }).Genero!.tipo);

            }

        }



        private void LivroItem_Load(object sender, EventArgs e)
        {

        }

        private void imagemUser_Click(object sender, EventArgs e)
        {
            //Sobre o Autor
        }

        private void LivroItem_Click(object sender, EventArgs e)
        {
        }

        private void imagemUser_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void imagemUser_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void pcbFavorito_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                pcbFavorito.Image = Resources.CoracaoCheio;




                _favoritosService.Add<Favorito, Favorito, FavoritoValidator>(new Favorito()
                {
                    livro = livroModel,
                    usuario = StaticKeys.usuarioEntity
                });

                StaticKeys.favoritos.Add(livroModel);
            }
            else
            {
                pcbFavorito.Image = Resources.CoracaoVazio;
                var item = StaticKeys.favoritos.FirstOrDefault(x => x.Id == livroModel.Id);

                if (item != null)
                {

                    var favoritoDelete = _favoritosService.Get<Favorito>(new List<String>() { "livro" }).ToList().FirstOrDefault(x => x.livro!.Id == item.Id);

                    _favoritosService.Delete(favoritoDelete!.Id);

                    StaticKeys.favoritos.Remove(item);

                    if (Principal.principal != null)
                    {
                        Principal.principal.carregarFavoritos();
                    }
                }
            }

            vazio = !vazio;
        }

        private void pcbApagar_Click(object sender, EventArgs e)
        {
            if (
                Utils.messageQuestion("Tem certeza que deseja apagar esta obra? (A operação não poderá ser refeita.)", "Livro")
                == DialogResult.Yes)
            {


                try
                {

                    var favoritos = _favoritosService.Get<Favorito>(new List<String>() { "usuario", "livro" })
                            .Where(x => x.usuario!.Id == StaticKeys.usuarioEntity!.Id && x.livro!.Id == livroModel.Id).ToList();


                    var generos = _generoLivroService.Get<GeneroLivro>(new List<String>() { "Livro" })
                            .Where(x => x.Livro!.Id == livroModel.Id).ToList();

                    var avaliacoes = _avaliacaoService.Get<Avaliacao>(new List<String>() { "Livro" })
                            .Where(x => x.Livro!.Id == livroModel.Id).ToList();


                    foreach (var aval in avaliacoes)
                    {
                        _avaliacaoService.Delete(aval.Id);
                    }

                    foreach (var fav in favoritos)
                    {
                        _favoritosService.Delete(fav.Id);
                    }

                    foreach (var gen in generos)
                    {
                        _generoLivroService.Delete(gen.Id);
                    }

                    _livroService.Delete(livroModel.Id);

                    Utils.messageBoxOk("Livro deletado com sucesso!", "Deletar livro");

                    if (Principal.principal != null)
                    {
                        Principal.principal!.carregarFavoritos();
                        Principal.principal!.carregarObras();
                    }


                }

                catch (Exception ex)
                {
                    Utils.messageExclamation("Ocorreu um erro, tente novamente", "Erro");
                }


            }


        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            new FormDadosLivro(livroModel).ShowDialog();
        }

        private void pcbEditar_Click(object sender, EventArgs e)
        {
            new FormNovoLivro(livroModel).ShowDialog();
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            new FormComentarios(livroModel).ShowDialog();
        }

        private void imagemUser_DoubleClick(object sender, EventArgs e)
        {
            if (livroModel.Autor != null)
            {
                new FormDadosUsuario(livroModel.Autor).ShowDialog();
            }
        }
    }
}
