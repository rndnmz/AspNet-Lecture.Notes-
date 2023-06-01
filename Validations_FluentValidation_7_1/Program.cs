
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// yukaridaki satýr bir web application inþa etmek üzere tanýmlanmýþ bir satýrdýr.

// Bu bölümünde bu uygulamada kullanýlacak olan servisleri projemize dahil ediyoruz.

builder.Services.AddControllersWithViews().AddFluentValidation(option =>
{
    option.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});



// Aþaðýdaki satýr ile de yukarýda tanýmladýðýmýz servisler ile uygulamanýn inþa edilmesi yani build edilmesini ya da ayaða kalkmasýný saðlýyoruz.
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


