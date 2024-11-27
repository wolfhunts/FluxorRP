using Fluxor;
using FluxorRP.Shared.Store.Dice;
using FluxorRP.Shared.Store.ListCharacter;

namespace FluxorRP.Shared.Store.Character
{
    public class CharacterEffect
    {
        public CharacterEffect(IState<DiceState> state, IState<ListCharacterState> stateCharacters)
        {
            DiceState = state;
            CharactersState = stateCharacters;
        }

        public IState<DiceState> DiceState { get; }
        public IState<ListCharacterState> CharactersState { get; }

        [EffectMethod(typeof(DiceRollAction))]
        public Task AddHealthFromDice(IDispatcher dispatcher)
        {            
            dispatcher.Dispatch(new CharacterAddHealthAction(this.DiceState.Value.currentValue));

            return Task.CompletedTask;
        }
        [EffectMethod(typeof(ListCharacterSelectAction))]
        public Task LoadSelectedCharacter(IDispatcher dispatcher)
        {
            var selectedChar = this.CharactersState.Value.Characters.First(_ => _.Id == this.CharactersState.Value.selectedValue);
            dispatcher.Dispatch(new CharacterLoadSelectedAction(selectedChar.Name, selectedChar.health, selectedChar.strength));
            
            return Task.CompletedTask;
        }
    }
}
