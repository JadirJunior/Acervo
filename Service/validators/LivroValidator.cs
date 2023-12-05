using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class LivroValidator : AbstractValidator<Livro>
    {

        public LivroValidator()
        {
            RuleFor(c => c.Autor)
                .NotEmpty().WithMessage("Você precisa estar logado para enviar um livro!")
                .NotNull().WithMessage("Você precisa estar logado para enviar um livro!");

            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor envie o documento do livro.")
                .NotNull().WithMessage("Por favor envie o documento do livro.");

            RuleFor(c => c.Sinopse)
                .NotEmpty().WithMessage("Por favor escreva uma sinopse para o seu livro.")
                .NotNull().WithMessage("Por favor escreva uma sinopse para o seu livro.");

            RuleFor(c => c.Thumbnail)
                .NotEmpty().WithMessage("Por favor envie uma imagem de capa para o livro")
                .NotNull().WithMessage("Por favor envie uma imagem de capa para o livro");

            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Por favor envie o título do livro")
                .NotNull().WithMessage("Por favor envie o título do livro");
        }

    }
}
