using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {

        public GeneroValidator()
        {
            RuleFor(c => c.tipo)
                .NotEmpty().WithMessage("Por favor informe o gênero.")
                .NotNull().WithMessage("Por favor informe o gênero.");

            RuleFor(c => c.descricao)
                .NotEmpty().WithMessage("Por favor faça uma sucinta descrição.")
                .NotNull().WithMessage("Por favor faça uma sucinta descrição.");
        }

    }
}
