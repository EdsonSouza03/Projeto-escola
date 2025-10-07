using Microsoft.EntityFrameworkCore;
using Projeto_escola.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; // <- importante se faltar

var builder = WebApplication.CreateBuilder(args);

// Conexão com MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Detecta automaticamente a versão do MySQL
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
