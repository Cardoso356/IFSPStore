using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.")
                .Length(50)
                .WithMessage("Nome pode ter no máximo 50 caracteres.");

            RuleFor(c => c.Preco)
                .NotEmpty().WithMessage("Por favor, informe o preço.")
                .NotNull().WithMessage("Por favor, informe o preço.");

            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor, informe a quantidade.")
                .NotNull().WithMessage("Por favor, informe a quantidade.");

        }
    }
}
