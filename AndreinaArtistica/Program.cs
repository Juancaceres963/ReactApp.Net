using AndreinaArtistica.Helpers;
using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

var builder = WebApplication.CreateBuilder(args);

RegisterInterfaces(builder.Services);

static void RegisterInterfaces(IServiceCollection services)
{
    services.AddScoped<IArtPiecesResource, ArtPiecesResource>();
    services.AddScoped<IDatabaseHelper, DatabaseHelper>();
}

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the DbContext
builder.Services.AddDbContext<AndreinartisticaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AndreinartisticaContext"));
});

var app = builder.Build();

// Check and apply migrations at startup
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AndreinartisticaContext>();

    // Check if the database exists
    if (!dbContext.Database.CanConnect())
    {
        // Create the database
        dbContext.Database.EnsureCreated();

        // Create the migration if it does not exist
        var migrator = dbContext.GetService<IMigrator>();

        try
        {
            // This will create a migration script based on the current model and apply it
            migrator.Migrate();
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., logging)
            Console.WriteLine($"Migration failed: {ex.Message}");
        }
    }
    else
    {
        // Ensure the database is up-to-date with any pending migrations
        dbContext.Database.Migrate();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
