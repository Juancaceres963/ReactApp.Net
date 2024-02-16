using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

RegisterInterfaces(builder.Services);

static void RegisterInterfaces(IServiceCollection services)
{
    services.AddScoped<IArtPiecesResource, ArtPiecesResource>();
}

builder.Services.AddDbContext<AndreinartisticaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AndreinartisticaContext"));
});

var app = builder.Build();

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

app.MapFallbackToFile("index.html"); ;

app.Run();
