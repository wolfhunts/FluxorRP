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
            return new CharacterState  { Strength = state.Strength + action.RollResult };
        }
    }

    public class MonsterReducer
    {
        [ReducerMethod]
        public static MonsterState ReduceMonsterAttack(MonsterState state, MonsterAttackAction action)
        {
            return new MonsterState { Health = state.Health - action.Damage };
        }
    }

}
