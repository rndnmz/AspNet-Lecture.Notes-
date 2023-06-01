
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// yukaridaki sat�r bir web application in�a etmek �zere tan�mlanm�� bir sat�rd�r.

// Bu b�l�m�nde bu uygulamada kullan�lacak olan servisleri projemize dahil ediyoruz.

builder.Services.AddControllersWithViews().AddFluentValidation(option =>
{
    option.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});



// A�a��daki sat�r ile de yukar�da tan�mlad���m�z servisler ile uygulaman�n in�a edilmesi yani build edilmesini ya da aya�a kalkmas�n� sa�l�yoruz.
var app = builder.Build();



//app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=CreateCustomer}/{id?}"
    );

app.Run();


