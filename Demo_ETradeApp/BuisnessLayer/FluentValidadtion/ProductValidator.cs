using EntiLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.FluentValidadtion
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x=>x.ProductName).MinimumLength(3).WithMessage("Ürün adı 3 harften kısa olamaz");

            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");

            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Ürün stoğu boş geçilemez");
        }
    }
}
