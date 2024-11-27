using Fluxor;
using FluxorRP.Shared.Store.Character;
using FluxorRP.Shared.Store.ListCharacter;
using FluxorRP.Shared.Store.ListMonster;

namespace FluxorRP.Shared.Store.Monster
{
    public class MonsterEffect
    {
        public MonsterEffect(IState<CharacterState> state, IState<ListMonsterState> stateMonsters)
        {
            CharacterState = state;
            MonstersState = stateMonsters;
        }

        public IState<ListMonsterState> MonstersState { get; }

        public IState<CharacterState> CharacterState { get; }

        [EffectMethod(typeof(MonsterLaunchAttackAction))]
        public Task AddHealthFromDice(IDispatcher dispatcher)
        {            
            dispatcher.Dispatch(new MonsterAttackAction(this.CharacterState.Value.strength));

            return Task.CompletedTask;
        }

        [EffectMethod(typeof(ListMonsterSelectAction))]
        public Task LoadSelectedMonster(IDispatcher dispatcher)
        {
            var selectedChar = this.MonstersState.Value.Monsters.First(_ => _.Id == this.MonstersState.Value.selectedValue);
            dispatcher.Dispatch(new MonsterLoadSelectedAction(selectedChar.Name, selectedChar.health));

            return Task.CompletedTask;
        }
    }
}
