using Microsoft.EntityFrameworkCore;
using Projeto_escola.Data;
using Pomelo.EntityFrameworkCore.MySql;
using Pomelo.EntityFrameworkCore.MySql.Storage; // 👈 IMPORTANTE!

var builder = WebApplication.CreateBuilder(args);

// Conexão com MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    );
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
