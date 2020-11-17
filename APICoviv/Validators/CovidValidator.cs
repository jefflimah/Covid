using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_A.P.I___COVID.Models;

namespace Trabalho_A.P.I___COVID.Validators
{
    public class CovidValidator : AbstractValidator<Covid>
    {
        public CovidValidator()
        {
            RuleFor(p => p.nome)
                .NotEmpty().WithMessage("Nome obrigatório")
                .NotNull().WithMessage("Nome obrigatório")
                .MinimumLength(3).WithMessage("Mínimo de 3 caracteres")
                .MaximumLength(50).WithMessage("Máximo com 50 caracteres");
        }

        private object RuleFor(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
