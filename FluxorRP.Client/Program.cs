using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using FluxorRP.Shared.Data;
using FluxorRP.Shared.Store.ListCharacter;
using FluxorRP.Shared.Store.ListMonster;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Program).Assembly, typeof(FluxorRP.Shared.Store.Dice.DiceRollAction).Assembly,
    typeof(FluxorRP.Shared.Store.ListCharacter.ListCharacterSelectAction).Assembly,
                    typeof(FluxorRP.Shared.Store.ListMonster.ListMonsterSelectAction).Assembly);

    options.UseReduxDevTools();
});

await builder.Build().RunAsync();
