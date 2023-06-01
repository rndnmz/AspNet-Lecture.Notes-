using Microsoft.AspNetCore.Mvc;
using ViewComponent_10.Models;

namespace ViewComponent_10.ViewComponents
{
    public class KategoriViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Burada ilgili kodların olması gerekiyor. Örneğin ViewCompomemt'in ihtiyacı olan datayı veritabanından alınması gibi.. Alınan bu veriyi de View'e parametre olarak veriyoruz.
            List<Kategori> kategoriler = new List<Kategori>()
            { new Kategori() { Id=1, KategoriAdi="Elektronik", Aciklama="Elektronik Eşya" },
             new Kategori() { Id=2, KategoriAdi="Kalem", Aciklama="Kalem Eşya" },
             new Kategori() { Id=3, KategoriAdi="edebiyat", Aciklama="Edebiyat Eşya" },
            };
            return View(kategoriler);
        }
    }
}




/* View Component nedir
 * Partial view bir data kullanacaksa bu data mutlaka Controller üzerinden gelmek zorunda. Bunun başka yolu yok.
 *ComponentView ise Controller'ı devreden çıkarır ve kendisine ait olan class/sınıfa gider, verisini alır bunu View'de kullanır.
 *öncelikli olarak, bu sınıfı oluşturmamız gerekiyor. WebUI katmanı içinde ViewComponents isimli bir klasör oluşturuyoruz. Bu klasör içinde ilgili sınıfı (yani bu sınıfı) oluşturuyoruz. Class'a bir isim vermeliyiz: Kategor, ismin sonunada ViewComponent'i ekliyoruz.
 * Daha sonra bu sınıfın ViewComponent olarak çalışabilmesi için bu sınıfını miras alması gerekiyor.(using Microsoft.AspNetCore.Mvc; ekliyoruz)
 * Bu sınıfın tetiklenebilmesi için içinde bir tane metodu barındırması gerekiyor:
             public IViewComponentResult InVoke()
        {
            return View();
        }
 * Metodun geridönüş türü IVİewComponentResult olmalı ve Metot adı kesinlikle Invoke() olmalı.
 
 ** İlgili view Nerede barındırılacak?
    - 2 farklı yerde konumlandırılabilir.
        1- Views klasörü altında ilgili controller klasörünün altında Components klasörü olmalı. Bu klasörün altında da Bu sınıf ismi ile aynı isme sahip bir klasör olmalı. Bu klasörün içine ilgili view'imizi konumlandırıyoruz.
Views/Home/Components/Kategori/Default.cshtml

 
        2- Shared klasörü altında Components altında, Class ismi ile aynı isimde oluşturulan klasörün içinde ilgili View'i barındırmalıyız.
Views/Shared/Components/Kategori/Default.cshtml

 *View ismi ne olmalı?
        -Eğer Farklı bir isim vereceksek Default isminikullanabiliriz. Bu durumda bu ismi returnView() satırında parametre olarak vermemize gerek kalmayacak.
        -Farklı bir isim vereceksek, bu durumda bu ismi Invoke metodu içinde return View()'de parametre olarak vermeliyiz.

*ComponenetView'i kullanamak istediğimizde ilgili View içinde aşağıdaki gibi kullanabiliriz.
@Compnent Invoke("Kategori");
 
 
 
 
 
 
 
 
 
 
 
 */
