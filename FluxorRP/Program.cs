using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using FluxorRP.Client.Component;
using FluxorRP.Components;
using System.Reflection.Metadata;
using FluxorRP.Shared.Data;
using Microsoft.EntityFrameworkCore;
using FluxorRP.Shared.Store.ListCharacter;
using FluxorRP.Shared.Store.ListMonster;
var builder = WebApplication.CreateBuilder(args);

// Note: This sample requires the database to be created before running.

// Create
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Gobelin", health=15 });
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Orc", health =30 }); 
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Troll", health =45 });

//db.Add(new FluxorRP.Shared.Data.Character { Id =1, Name = "Jeune aventurier", health = 20, strength = 5 });
//db.Add(new FluxorRP.Shared.Data.Character { Id = 2,Name = "Aventurier confirmé", health = 40, strength = 15 });
//db.Add(new FluxorRP.Shared.Data.Character { Id = 3,Name = "Vétéran", health = 80, strength = 25 });
//db.SaveChanges();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });
builder.Services.AddDbContext<FluxorRPContext>(options =>
    options.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), "FluxorRP.db")}"));
builder.Services.AddScoped<ListCharacterFeature>();
builder.Services.AddScoped<ListMonsterFeature>();

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(
                    typeof(Program).Assembly,
                    typeof(FluxorRP.Shared.Store.Dice.DiceRollAction).Assembly,
                    typeof(FluxorRP.Shared.Store.ListCharacter.ListCharacterSelectAction).Assembly,
                    typeof(FluxorRP.Shared.Store.ListMonster.ListMonsterSelectAction).Assembly,
                    typeof(FluxorRP.Client._Imports).Assembly);
    options.UseReduxDevTools();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FluxorRP.Client._Imports).Assembly);

app.Run();
