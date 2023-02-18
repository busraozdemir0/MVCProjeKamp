﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında kısmını boş geçemezsiniz!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar unvan kısmını boş geçemezsiniz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik veri girişi yapın!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayın!");
           
            //yazar hakkında yazısının içinde en az bir tane 'A' harfi olması kuralı
            //RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmı en az bir tane 'a' harfi içermelidir");
        }
    }
}
