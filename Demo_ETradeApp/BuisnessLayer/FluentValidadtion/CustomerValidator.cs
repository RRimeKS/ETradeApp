using EntiLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.FluentValidadtion
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.CustomerFirstName).NotEmpty().WithMessage("Müşteri Adı boş geçilemez.");
            RuleFor(x => x.CustomerFirstName).MinimumLength(3).WithMessage("Müşteri Adı 3 harften kısa olamaz.");

            RuleFor(x => x.CustomerLastName).NotEmpty().WithMessage("Müşteri soyadı boş geçilemez.");
            RuleFor(x => x.CustomerLastName).MinimumLength(3).WithMessage("Müşteri soyadı 3 harften kısa olamaz.");

            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Şehri adı boş geçilemez.");
            RuleFor(x => x.CustomerCity).MinimumLength(3).WithMessage("Şehir Adı 3 harften kısa olamaz.");
        }
    }
}
