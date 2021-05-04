using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PrylanLibary.Models;

namespace PrylanLibary.Validators
{
    public class ArtikelValidator : AbstractValidator<Artikel>
    {
        public ArtikelValidator()
        {
            RuleFor(a => a.Besk)
                .Cascade(CascadeMode.Stop)
                .Must(NotNullOrWhiteSpace)
                .WithMessage("Beskrivning: Är tomt")
                .Length(2, 25)
                .WithMessage("Beskrivning: Måste vara minst 2 och max 25 tecken");
            RuleFor(a => a.SerieNr)
               .Cascade(CascadeMode.Stop)
               .Must(NotNullOrWhiteSpace)
               .WithMessage("SerieNr: Är tomt")
               .Length(2, 25)
               .WithMessage("SerieNr: Måste vara minst 2 och max 25 tecken");
        }

        protected bool NotNullOrWhiteSpace(string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
