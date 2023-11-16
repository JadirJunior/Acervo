using AcervoDomain.entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.validators
{ 
    public class UsuarioValidator : AbstractValidator<Usuario>
    {

        public UsuarioValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe seu nome")
                .NotNull().WithMessage("Por favor informe seu nome");

            RuleFor(c => c.User)
                .NotEmpty().WithMessage("Por favor informe o nome de usuário.")
                .NotNull().WithMessage("Por favor informe o nome de usuário.");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor informe a sua senha.")
                .NotNull().WithMessage("Por favor informe a sua senha.");

        }

    }
}
