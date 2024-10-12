using Fluxor;
using FluxorRP.Client.Models;
using System.Net.Http.Json;
using static FluxorRP.Client.Action.Action;

namespace FluxorRP.Client.UseCase;

public class RollDiceActionEffect: Effect<RollDiceAction>
{
    private readonly HttpClient http;

    public RollDiceActionEffect(HttpClient http)
    {
        this.http = http;
    }

    public override async  Task HandleAsync(RollDiceAction action, IDispatcher dispatcher)
    {
        await Task.Delay(500);
        
        var roll = await http.GetFromJsonAsync<DiceRoll[]>("api?nbde=1&tpde=6");

        dispatcher.Dispatch(new RollDiceActionResult(roll.First().value));
    }
}

