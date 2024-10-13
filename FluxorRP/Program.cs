using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using FluxorRP.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(
                    typeof(Program).Assembly,
                    typeof(FluxorRP.Client._Imports).Assembly,
                    typeof(FluxorRP.Shared.Store.MonsterAttackAction).Assembly);

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
