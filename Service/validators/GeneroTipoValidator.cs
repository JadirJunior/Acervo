using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class GeneroTipoValidator : AbstractValidator<GeneroTipo>
    {

        public GeneroTipoValidator()
        {
            RuleFor(c => c.livro)
                .NotEmpty().WithMessage("Por favor informe qual livro está favoritando.")
                .NotNull().WithMessage("Por favor informe qual livro está favoritando.");

            RuleFor(c => c.genero)
                .NotEmpty().WithMessage("Por favor informe o gênero.")
                .NotNull().WithMessage("Por favor informe o gênero.");
        }

    }
}
