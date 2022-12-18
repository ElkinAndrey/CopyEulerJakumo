using EulerJakumo.Data;
using EulerJakumo.Models;
using System;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EulerJakumoDataBase; Trusted_Connection = True")
);

builder.Services.AddTransient<IApplicationRepository, EFApplicationRepository>(); // передаю IApplicationRepository в конструкторы контроллеров
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
    pattern: "{action=Problems}",
    defaults: new { controller = "Home" });

app.Run();