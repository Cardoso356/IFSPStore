﻿using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.")
                .Length(50)
                .WithMessage("Nome pode ter no máximo 50 caracteres.");
        }
    }
}