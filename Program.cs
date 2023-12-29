var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // mvc sablonu ekleme

var app = builder.Build();

app.UseStaticFiles(); // wwwroot klasorunu dısarıya actık (statik dosyları kullanabilmek icin yazdık)

app.UseRouting(); // routing yonlendirmesini aktif ettik

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/abc", () => "deneme!");

// app.MapDefaultControllerRoute(); controller/action/id? yapısı

app.MapControllerRoute( // controller/action/id? yapısı elle yazdık usttekiyle aynı
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

);

app.Run();
