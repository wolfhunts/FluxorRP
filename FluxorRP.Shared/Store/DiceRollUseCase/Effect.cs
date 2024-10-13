using Fluxor;
using FluxorRP.Shared.Models;
using System.Net.Http.Json;

namespace FluxorRP.Shared.Store.DiceRollUseCase;

public class Effect : Effect<RollDiceAction>
{
    private readonly HttpClient http;

    public Effect(HttpClient http)
    {
        this.http = http;
    }

    public override async Task HandleAsync(RollDiceAction action, IDispatcher dispatcher)
    {
        await Task.Delay(500);

        var roll = await http.GetFromJsonAsync<DiceRoll[]>("api?nbde=1&tpde=6");

        dispatcher.Dispatch(new RollDiceActionResult(roll.First().value));
    }
}
