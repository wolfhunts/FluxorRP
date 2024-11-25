using Fluxor;
using FluxorRP.Shared.Store.Character;

namespace FluxorRP.Shared.Store.Monster
{
    public class MonsterEffect
    {
        public MonsterEffect(IState<CharacterState> state)
        {
            CharacterState = state;
        }

        public IState<CharacterState> CharacterState { get; }

        [EffectMethod(typeof(MonsterLaunchAttackAction))]
        public Task MonsterAttackEffect(IDispatcher dispatcher)
        {            
            dispatcher.Dispatch(new CharacterAddHealthAction(0 - new Random().Next(1, this.CharacterState.Value.strength)));
            dispatcher.Dispatch(new MonsterAttackAction(this.CharacterState.Value.strength));

            return Task.CompletedTask;
        }
    }
}
