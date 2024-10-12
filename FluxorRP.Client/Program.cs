using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.dejete.com") });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Program).Assembly);
    options.UseReduxDevTools();
});

await builder.Build().RunAsync();
