using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register interfaces
RegisterInterfaces(builder.Services);

static void RegisterInterfaces(IServiceCollection services)
{
    services.AddScoped<IArtPiecesResource, ArtPiecesResource>();
}

// Configure DbContext with SQL Server
builder.Services.AddDbContext<AndreinartisticaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AndreinartisticaContext"));
});

var app = builder.Build();

// Apply pending migrations and create the database if it doesn’t exist
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AndreinartisticaContext>();
    dbContext.Database.Migrate(); // This applies migrations at startup
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
