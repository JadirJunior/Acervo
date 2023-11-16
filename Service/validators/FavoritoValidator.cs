using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class FavoritoValidator : AbstractValidator<Favorito>
    {

        public FavoritoValidator()
        {
            RuleFor(c => c.livro)
                .NotEmpty().WithMessage("Por favor informe qual livro está favoritando.")
                .NotNull().WithMessage("Por favor informe qual livro está favoritando.");

            RuleFor(c => c.usuario)
                .NotEmpty().WithMessage("Você precisa estar logado para favoritar um livro!")
                .NotNull().WithMessage("Você precisa estar logado para favoritar um livro!");
        }

    }
}
