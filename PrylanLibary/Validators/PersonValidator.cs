using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using FluentValidation;
using PrylanLibary.Models;

namespace PrylanLibary.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        private const string PERSNR_REGEX = "^[0-9]{6}[-][0-9]{4}$";

        public PersonValidator()
        {
            RuleFor(p => p.Fornamn)
                .Cascade(CascadeMode.Stop)
                .Must(NotNullOrWhiteSpace)
                .WithMessage("Förnamn: Är tomt")
                .Length(2, 25)
                .WithMessage("Förnamn: Måste vara minst 2 och max 25 tecken");
            RuleFor(p => p.Efternamn)
                .Cascade(CascadeMode.Stop)
                .Must(NotNullOrWhiteSpace)
                .WithMessage("Efternamn: Är tomt")
                .Length(2, 25)
                .WithMessage("Efternamn: Måste vara minst 2 och max 25 tecken");
            RuleFor(p => p.PersNr)
                .Matches(PERSNR_REGEX)
                .WithMessage("PersNr: Felaktigt format ######-####");
            RuleFor(p => p.Tillhorighet)
                .Must(NotNullOrWhiteSpace)
                .WithMessage("Tillhörighet: Är tomt")
                .Length(2, 25)
                .WithMessage("Tillhörighet: Måste vara minst 2 och max 25 tecken");
        }

        protected bool NotNullOrWhiteSpace(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        public static bool IsPersNrValid(string persNr)
        {
            return Regex.IsMatch(persNr, PERSNR_REGEX);
        }
    }
}
