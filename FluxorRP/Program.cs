using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using FluxorRP.Client.Component;
using FluxorRP.Components;
using System.Reflection.Metadata;
using FluxorRP.Shared.Data;
var builder = WebApplication.CreateBuilder(args);

using var db = new FluxorRP.Shared.Data.FluxorRPContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Gobelin", health=15 });
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Orc", health =30 }); 
//db.Add(new FluxorRP.Shared.Data.Monster { Name = "Troll", health =45 });

//db.Add(new FluxorRP.Shared.Data.Character { Name = "Jeune aventurier" , health=20 , strength=5});
//db.Add(new FluxorRP.Shared.Data.Character { Name = "Aventurier confirmé", health = 40, strength = 15 });
//db.Add(new FluxorRP.Shared.Data.Character { Name = "Vétéran", health = 80, strength = 25 });

//db.SaveChanges();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(
                    typeof(Program).Assembly,
                    typeof(FluxorRP.Shared.Store.Dice.DiceRollAction).Assembly,
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
