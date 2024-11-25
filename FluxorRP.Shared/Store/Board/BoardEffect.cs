using Fluxor;
using FluxorRP.Shared.Store.Character;
using FluxorRP.Shared.Store.Monster;

namespace FluxorRP.Shared.Store.Board
{
    public class BoardEffect
    {
        public BoardEffect(IState<CharacterState> character, IState<MonsterState> monster)
        {
            Character = character;
            Monster = monster;
        }

        public IState<CharacterState> Character { get; }
        public IState<MonsterState> Monster { get; }

        [EffectMethod(typeof(MonsterAttackAction))]
        public Task IsEndOfGame(IDispatcher dispatcher)
        {
            if (this.Character.Value.health < 0 || this.Monster.Value.health < 0)
            {
                dispatcher.Dispatch(new BoardEndOfGameAction(true, this.Monster.Value.health < 0));
            }

            return Task.CompletedTask;
        }
    }
}
