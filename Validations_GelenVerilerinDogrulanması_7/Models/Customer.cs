using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Validations_GelenVerilerinDogrulanması_7.Models.ModelMetaDataTypes;

namespace Validations_GelenVerilerinDogrulanması_7.Models
{
    [ModelMetadataType(typeof(CustomerMetaData))]
    public class Customer
    {
        //ModelDataType ile validation işlemi yapmak istiyorum bu Class'ı aşşağıdaki sadecepropertylerden oluşan bir yer haline getirmem gerekecek.
        public int Id { get; set; }
        public string Name { get; set; }
        public string KimlikNo { get; set; }
        public string Email { get; set; }


    }
}
