using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class GeneroLivroValidator : AbstractValidator<GeneroLivro>
    {

        public GeneroLivroValidator()
        {
            RuleFor(c => c.Genero)
                .NotEmpty().WithMessage("Por favor informe o gênero.")
                .NotNull().WithMessage("Por favor informe o gênero.");

            RuleFor(c => c.Livro)
                .NotEmpty().WithMessage("Por favor informe o livro.")
                .NotNull().WithMessage("Por favor informe o livro.");
        }

    }
}
