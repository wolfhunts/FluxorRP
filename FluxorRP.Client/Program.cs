using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using FluxorRP.Shared.Store.CaptainSwordee;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Program).Assembly, typeof(FluxorRP.Shared.Store.Dice.DiceRollAction).Assembly);
    options.AddMiddleware<GifMiddleware>();

    options.UseReduxDevTools();
});

await builder.Build().RunAsync();
