using Fluxor;

namespace FluxorRP.Shared.Store.Dice
{
    public static class DiceReducer
    {
        [ReducerMethod(typeof(DiceRollAction))]
        public static DiceState Reduce(DiceState state)
        {
            int newDiceValue = new Random().Next(1, 6);
            return state with { currentValue = newDiceValue };
        }
    }
}
