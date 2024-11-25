using Fluxor;
using FluxorRP.Shared.Store.Dice;

namespace FluxorRP.Shared.Store.Character
{
    public class CharacterEffect
    {
        public CharacterEffect(IState<DiceState> state)
        {
            DiceState = state;
        }

        public IState<DiceState> DiceState { get; }

        [EffectMethod(typeof(DiceRollAction))]
        public Task AddHealthFromDice(IDispatcher dispatcher)
        {            
            dispatcher.Dispatch(new CharacterAddHealthAction(this.DiceState.Value.currentValue));

            return Task.CompletedTask;
        }
    }
}
