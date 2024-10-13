using Fluxor;

namespace FluxorRP.Shared.Store.CharacterUseCase;

public class Reducer
{
    [ReducerMethod]
    public CharacterState ReduceRollDice(CharacterState state, RollDiceAction action)
        => state with { loading = true };

    [ReducerMethod]
    public CharacterState ReduceFetchDataResultAction(CharacterState state, RollDiceActionResult action)
        => state with { loading = false, lastRoll = action.roll, Strength = state.Strength + action.roll };
}
