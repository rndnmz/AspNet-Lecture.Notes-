using FluentValidation;

namespace Validations_FluentValidation_7_1.Models.FluentValidations
{
    // ilgili validasyonn işlemlerini yapanilmem için öncelikle FluentValidation içinde bulunan AbstractValidator<T> class'ını inherit etmemiz gerekiyor. Tyerine de ben hangi model/entity için validasyon yapacak isem o Class'ı yazmalıyım. Product yazarsam Product için doğrulama işlemlerini yapacak. Customer yazarsam, Customer için doğrulama işlemlerini yapcak.
    // Daha sonra veri doğrulama işlemini yapabilmek için bu sınıf için constructor oluşturuyorumç Ve aşağıdaki gibi Validation işlemlerini yapıyorum.
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş bırakılamaz.");
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("name alanı en fazla 25 karakter olabilir.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("name alanı en az 2 karakter olabilir.");

            RuleFor(x => x.KimlikNo).NotNull().WithMessage("Kimlik No alanı boş bırakılamaz. Lütfen geçerli bir Kimlik No giriniz. ");
            RuleFor(x => x.KimlikNo).Length(11).WithMessage("Kimlik numaranızı geçerli değil. Lütfen 11 karakterden oluşan kimlik numaranızı giriniz.");
            RuleFor(x => x.Email).NotNull().WithMessage("E-mail alanı boş bırakılamaz. Lütfen geçerli bir e-mail giriniz. ");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email adresiniz geçerli değil. Lütfen Geçerli bir e-mail adresi giriniz.");
        }

    }
}
