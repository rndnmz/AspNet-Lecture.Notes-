using System.ComponentModel.DataAnnotations;

namespace Validations_GelenVerilerinDogrulanması_7.Models.ModelMetaDataTypes
{
    public class CustomerMetaData
    {
        //Customer modelinin içindeki validataion işlemi yapılacak property'leri buraya taşıyorum..

        [Required(ErrorMessage = "Id'alanı boş geçilemez.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name'alanı boş geçilemez.")]
        [StringLength(25, ErrorMessage = "Name alanı en fazla 25 karakter olabilir."), MinLength(2, ErrorMessage = "Name alanı en az 2 karakter olabilir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kimlik No'alanı boş geçilemez.")]
        [StringLength(11, ErrorMessage = "Lütfen geçerli bir kimlik no giriniz"), MinLength(11, ErrorMessage = "Lütfen geçerli bir kimlik no giriniz")]
        public string KimlikNo { get; set; }
        [Required(ErrorMessage = "Email'alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir Email adresi giriniz. Örn: abc@xyz.com")]
        public string Email { get; set; }
    }
}
