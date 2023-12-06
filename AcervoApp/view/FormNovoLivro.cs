using AcervoApp.infra;
using AcervoApp.models;
using AcervoApp.utils;
using AcervoDomain.entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using Service.Base;
using Service.validators;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcervoApp.view
{
    public partial class FormNovoLivro : MaterialForm
    {

        byte[] novaObra = null;
        byte[] thumbnail = null;
        bool edicao;

        Livro livro;
        List<Genero> Generos = new List<Genero>();
        List<GeneroModel> generoModels = new List<GeneroModel>();
        List<GeneroLivro> selecionados2 = new List<GeneroLivro>();

        private readonly IBaseService<Genero> _generoService;
        private readonly IBaseService<GeneroLivro> _generoLivroService;
        private readonly IBaseService<Livro> _livroService;

        void inicializarGeneros()
        {
            var generos = _generoService!.Get<Genero>().ToList();

            foreach (var genero in generos)
            {
                lstGeneros.Items.Add(genero.tipo);
                Generos.Add(genero);
            }
        }

        public FormNovoLivro()
        {
            InitializeComponent();
            _generoService = Principal.principal._generoService;
            _livroService = Principal.principal._livroService;
            _generoLivroService = Principal.principal._generoLivroService;

            inicializarGeneros();


            edicao = false;
        }

        public FormNovoLivro(Livro livro)
        {
            InitializeComponent();
            _generoService = Principal.principal._generoService;
            _livroService = Principal.principal._livroService;
            _generoLivroService = Principal.principal._generoLivroService;

            this.livro = livro;

            inicializarGeneros();


            foreach (ListViewItem item in lstGeneros.Items)
            {
                var g = Generos.Find(x => x.tipo == item.Text);

                var generoTipo = _generoLivroService!.Get<GeneroLivro>(new List<String>() { "Genero", "Livro" })
                        .FirstOrDefault(x => x.Livro!.Id == livro.Id && x.Genero!.Id == g.Id);

                if (generoTipo != null)
                {
                    selecionados2.Add(generoTipo);

                    lstGeneros.Items[lstGeneros.Items.IndexOf(item)].Focused = true;
                    lstGeneros.Items[lstGeneros.Items.IndexOf(item)].Selected = true;
                    lstGeneros.Select();
                }
            }

            txtTitulo.Text = livro.Titulo;
            txtSinopse.Text = livro.Sinopse;

            if (livro.Documento != null)
            {
                novaObra = livro.Documento;
            }

            if (livro.Thumbnail != null)
            {
                thumbnail = livro.Thumbnail;
                pcbImagem.Image = Conversoes.BytesToImage(livro.Thumbnail);
            }

            edicao = true;
        }

        private void btnSelecionarPdf_Click(object sender, EventArgs e)
        {
            opfSelecionar.Filter = "Pdf Files|*.pdf";


            if (opfSelecionar.ShowDialog() == DialogResult.OK)
            {
                novaObra = File.ReadAllBytes(opfSelecionar.FileName);
                txtCaminho.Text = opfSelecionar.FileName;
            }

        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            opfSelecionar.Title = "Selecione uma imagem";
            opfSelecionar.Filter = "Imagens (*.ico;*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png;*.ico";

            if (opfSelecionar.ShowDialog() == DialogResult.OK)
            {
                thumbnail = File.ReadAllBytes(opfSelecionar.FileName);
                pcbImagem.Image = Image.FromFile(opfSelecionar.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (lstGeneros.SelectedIndices.Count == 0)
            {
                Utils.messageExclamation("Selecione pelo menos um gênero!", "Novo Livro");
            }
            else
            {
                Livro livroAtualizado = new Livro()
                {
                    Autor = StaticKeys.usuarioEntity,
                    Avaliacoes = new List<Avaliacao>(),
                    Documento = novaObra,
                    Titulo = txtTitulo.Text,
                    Sinopse = txtSinopse.Text,
                    Thumbnail = thumbnail
                };

                foreach (int a in lstGeneros.SelectedIndices)
                {
                    var gen = Generos.FirstOrDefault(x => x.tipo == lstGeneros.Items[a].Text);
                    if (gen != null)
                    {
                        selecionados2.Add(new GeneroLivro()
                        {
                            Genero = gen,
                            Livro = livroAtualizado
                        });

                    }
                }

                livroAtualizado.Generos = selecionados2;

                if (!edicao)
                {
                    var livros = _livroService.Get<Livro>().ToList();
                    _livroService.Add<Livro, Livro, LivroValidator>(livroAtualizado);

                    foreach (var g in livroAtualizado.Generos)
                    {
                        _generoLivroService.Add<GeneroLivro, GeneroLivro, GeneroLivroValidator>(g);
                    }

                    Utils.messageBoxOk("Livro inserido com sucesso!", "Cadastro de Livro");

                    this.Close();
                }
                else
                {


                    var generosLivro = _generoLivroService.Get<GeneroLivroModel>(new List<String>() { "Genero", "Livro" })
                            .Where(x => x.Livro!.Id == livro.Id).ToList();

                    livroAtualizado.Id = livro.Id;

                    livroAtualizado.Generos.Clear();
                    var livroNovo = _livroService.Update<Livro, Livro, LivroValidator>(livroAtualizado);

                    foreach (ListViewItem item in lstGeneros.Items)
                    {

                        //Salvando os generos novos e editado
                        var ret = generosLivro.Find(x => x.tipoGenero == item.Text);

                        if (ret != null)
                        {
                            _generoLivroService.Delete(ret.Id);

                            if (item.Selected)
                            {
                                _generoLivroService.Add<GeneroLivro, GeneroLivro, GeneroLivroValidator>(
                                    new GeneroLivro()
                                    {
                                        Genero = _generoService.GetById<Genero>(ret.generoId),
                                        Livro = livroNovo
                                    });
                            }
                        }
                        else
                        {
                            if (item.Selected)
                            {
                                _generoLivroService.Add<GeneroLivro, GeneroLivro, GeneroLivroValidator>(
                                    new GeneroLivro()
                                    {
                                        Genero = _generoService.Get<Genero>().Where(x => x.tipo == item.Text).FirstOrDefault(),
                                        Livro = livroNovo
                                    });
                            }
                        }

                    }

                    Utils.messageBoxOk("Livro atualizado com sucesso!", "Edição");

                    if (Principal.principal != null)
                    {
                        Principal.principal.carregarObras();
                    }

                    this.Close();
                }
            }



        }

        private void lstGeneros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
