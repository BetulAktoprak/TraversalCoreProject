﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz").MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz").MinimumLength(5).WithMessage("Lütfen 5 karakterden daha uzun bir isim giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber fotoğrafını ekleyiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını ekleyiniz");
           
        }
    }
}
