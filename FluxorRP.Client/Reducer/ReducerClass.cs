using Fluxor;
using FluxorRP.Client.Class;
using static FluxorRP.Client.Action.Action;

namespace FluxorRP.Client.Reducer
{

    public class CharacterReducer
    {
        [ReducerMethod]
        public CharacterState ReduceRollDice(CharacterState state, RollDiceAction action)
            => state with { loading = true };

        [ReducerMethod]
        public CharacterState ReduceFetchDataResultAction(CharacterState state, RollDiceActionResult action) 
            => state with { loading = false, lastRoll = action.roll, Strength = state.Strength + action.roll };
    }

    public class MonsterReducer
    {
        [ReducerMethod]
        public MonsterState ReduceMonsterAttack(MonsterState state, MonsterAttackAction action)
            => state with { Health = state.Health - action.Damage };
    }

}
