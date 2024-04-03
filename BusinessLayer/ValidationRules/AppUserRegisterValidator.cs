using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen soyadınızı giriniz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail adresinizi giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Lütfen şifrenizi tekrar giriniz");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler uyumlu değil");

        }
    }
}
