using AcervoDomain.entities;
using FluentValidation;

namespace Service.validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {

        public AvaliacaoValidator()
        {
            RuleFor(c => c.estrelas)
                .NotEmpty().WithMessage("Por favor informe quantas estrelas.")
                .NotNull().WithMessage("Por favor informe quantas estrelas.");

            RuleFor(c => c.livro)
                .NotEmpty().WithMessage("Por favor informe o livro que irá avaliar!")
                .NotNull().WithMessage("Por favor informe o livro que irá avaliar!");
        }

    }
}
