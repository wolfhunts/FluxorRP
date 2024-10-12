using Fluxor;
using FluxorRP.Client.Class;
using static FluxorRP.Client.Action.Action;

namespace FluxorRP.Client.Reducer
{

    public class CharacterReducer
    {
        [ReducerMethod]
        public CharacterState ReduceRollDice(CharacterState state, RollDiceAction action)
        {
            return new CharacterState(state.Health,state.Strength + action.RollResult);
        }
    }

    public class MonsterReducer
    {
        [ReducerMethod]
        public MonsterState ReduceMonsterAttack(MonsterState state, MonsterAttackAction action)
        {
            return new MonsterState(state.Health - action.Damage, state.Domage);
        }
    }

}
