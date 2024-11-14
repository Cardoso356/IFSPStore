using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.")
                .MaximumLength(50)
                .WithMessage("Nome pode ter no máximo 50 caracteres.");

            RuleFor(c => c.Email)
                .EmailAddress().WithMessage("Por favor, informe o email.")
                .NotEmpty().WithMessage("Por favor, informe o email.")
                .NotNull().WithMessage("Por favor, informe o email.");

            RuleFor(c => c.Senha)
                .MinimumLength(8).WithMessage("Sua senha tem que ter no mínimo 8 caracteres.")
                .MaximumLength(16).WithMessage("Sua senha tem quer ter no máximo 16 caracteres.")
                .Matches(@"[A-Z]+").WithMessage("Sua senha tem que ter ao menos uma letra maiúscula.")
                .Matches(@"[a-z]+").WithMessage("Sua senha tem que ter ao menos uma letra minúscula.")
                .Matches(@"[0-9]+").WithMessage("Sua senha tem que ter ao menos um número.")
                .Matches(@"[\!\?\*\.]+").WithMessage("Sua senha tem que ter ao menos um caractere especial (!?*.).")
                .NotEmpty().WithMessage("Por favor, informe a senha.")
                .NotNull().WithMessage("Por favor, informe a senha.");
                

            
        }
    }
}
