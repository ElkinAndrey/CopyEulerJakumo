using EulerJakumo.Data;
using EulerJakumo.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IApplicationRepository, FakeApplicationRepository>(); // передаю IApplicationRepository в конструкторы контроллеров
builder.Services.AddControllersWithViews(); // Добавление MVC


var app = builder.Build();
app.UseHttpsRedirection(); // Принудительное применение HTTPS
app.UseStaticFiles(); // Добавление статических фалов (css,  js)
app.UseRouting(); // Добавляет соответствие маршрута в конвейер ПО промежуточного слоя

app.MapControllerRoute(
    name: "default",
    pattern: "Problems/{number}",
    defaults: new { controller = "Home", action = "Problem" }); // От куда начинать

app.MapControllerRoute(
    name: "default",
    pattern: "{action=Index}",
    defaults: new { controller = "Home" }); // От куда начинать

app.Run();