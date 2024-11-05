using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator() 
        {
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor, informe o valor total.")
                .NotNull().WithMessage("Por favor, informe o valor total.");
                
        }
    }

    public class VendaItemValidator : AbstractValidator<VendaItem>
    {
        public VendaItemValidator()
        {
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor, informe o valor total.")
                .NotNull().WithMessage("Por favor, informe o valor total.");

            RuleFor(c => c.ValorUnitario)
                .NotEmpty().WithMessage("Por favor, informe o valor unitario.")
                .NotNull().WithMessage("Por favor, informe o valor unitario.");

            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor, informe a quantidade.")
                .NotNull().WithMessage("Por favor, informe a quantidade.");
        }
    }
}
