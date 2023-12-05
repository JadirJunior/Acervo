using AcervoDomain.entities;
using FluentValidation;

namespace Service.validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {

        public AvaliacaoValidator()
        {
            RuleFor(c => c.Estrelas)
                .NotEmpty().WithMessage("Por favor informe quantas estrelas.")
                .NotNull().WithMessage("Por favor informe quantas estrelas.");

            RuleFor(c => c.Livro)
                .NotEmpty().WithMessage("Por favor informe o livro que irá avaliar!")
                .NotNull().WithMessage("Por favor informe o livro que irá avaliar!");

            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("Você deve estar logado para avaliar uma obra!")
                .NotNull().WithMessage("Você deve estar logado para avaliar uma obra!");
        }

    }
}
