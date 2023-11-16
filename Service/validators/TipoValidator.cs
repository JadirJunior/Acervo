using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{
    public class TipoValidator : AbstractValidator<Tipo>
    {

        public TipoValidator()
        {
            RuleFor(c => c.tipo)
                .NotEmpty().WithMessage("Você precisa enviar um tipo de usuário")
                .NotNull().WithMessage("Você precisa enviar um tipo de usuário");

        }

    }
}
