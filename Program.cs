using L01__2020_BM_602___RESTAURANTE_.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios de controllers
builder.Services.AddControllers();

// Configurar DbContext
builder.Services.AddDbContext<RestauranteContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

var app = builder.Build();

// Habilitar archivos estáticos
app.UseStaticFiles();

// Mapear controllers
app.MapControllers();

app.Run();