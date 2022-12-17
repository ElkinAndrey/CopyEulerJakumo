using EulerJakumo.Data;
using EulerJakumo.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IApplicationRepository, FakeApplicationRepository>(); // передаю IApplicationRepository в конструкторы контроллеров
builder.Services.AddControllersWithViews(); // Добавление MVC


var app = builder.Build();
app.UseHttpsRedirection(); // Принудительное применение HTTPS
app.UseStaticFiles(); // Добавление статических фалов (css, js)
app.UseRouting(); // Добавляет соответствие маршрута в конвейер ПО промежуточного слоя

app.MapControllerRoute(
    name: "default",
    pattern: "{action}/Page/{page}",
    defaults: new { controller = "Home", action = "Problems" });

app.MapControllerRoute(
    name: "default",
    pattern: "Problems/{action}/{number}",
    defaults: new { controller = "Home", action = "Problem" });

app.MapControllerRoute(
    name: "default",
    pattern: "{action=AboutProject}",
    defaults: new { controller = "Home" });

app.Run();