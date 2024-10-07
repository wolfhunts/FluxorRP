using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FluxorRP.Client.Class;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Program).Assembly);
    options.UseReduxDevTools();
});

await builder.Build().RunAsync();
