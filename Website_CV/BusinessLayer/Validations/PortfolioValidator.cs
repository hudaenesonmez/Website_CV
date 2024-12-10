using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class PortfolioValidator:AbstractValidator<Portofolio>
    {
        public PortfolioValidator()
        {
                RuleFor(x=>x.Name).NotEmpty().WithMessage("Proje Adı Boş Olamaz");
                RuleFor(x => x.Name).MinimumLength(3).WithMessage("Proje Adı En Az 3 Karakter İçermelidir.");
                RuleFor (x => x.Name).MaximumLength(50).WithMessage("Proje Adı En Fazla 100 Karakter İçermelidir.");
                RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform Boş Olamaz");
                RuleFor(x => x.Platform).MaximumLength(20).WithMessage("Platform Adı En Fazla 20 Karakter İçermelidir.");
                RuleFor(x => x.Url).NotEmpty().WithMessage("URL Boş Olamaz");

        }
    }
}
