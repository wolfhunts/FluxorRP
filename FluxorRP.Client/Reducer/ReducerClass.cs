using Fluxor;
using FluxorRP.Client.Class;
using static FluxorRP.Client.Action.Action;

namespace FluxorRP.Client.Reducer
{

    public class CharacterReducer
    {
        [ReducerMethod]
        public static CharacterState ReduceRollDice(CharacterState state, RollDiceAction action)
        {
            state.Strength = state.Strength + action.RollResult;
            return state;
        }
    }

    public class MonsterReducer
    {
        [ReducerMethod]
        public static MonsterState ReduceMonsterAttack(MonsterState state, MonsterAttackAction action)
        {
            state.Health = state.Health - action.Damage ;
            return state;
        }
    }

}
