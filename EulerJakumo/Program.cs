using EulerJakumo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IApplicationRepository, FakeApplicationRepository>(); // передаю IApplicationRepository в конструкторы контроллеров
builder.Services.AddControllersWithViews(); // Добавление MVC


var app = builder.Build();
app.UseHttpsRedirection(); // Принудительное применение HTTPS
app.UseStaticFiles(); // Добавление статических фалов (css,  js)
app.UseRouting(); // Добавляет соответствие маршрута в конвейер ПО промежуточного слоя

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"); // От куда начинать

app.Run();