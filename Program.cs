

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews(); //inject the MVC services into the DI container
var app = builder.Build();
// fo bootstrap 5 we need to add the following line to the _Layout.cshtml file
app.UseStaticFiles(); // this is for the static files like css, js, images etc

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
