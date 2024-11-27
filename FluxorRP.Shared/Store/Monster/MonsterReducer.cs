using Fluxor;

namespace FluxorRP.Shared.Store.Monster
{
    public static class MonsterReducer
    {
        [ReducerMethod]
        public static MonsterState Reduce(MonsterState state, MonsterAttackAction action)
        {
            return state with { health = state.health - action.Point };
        }
        [ReducerMethod]
        public static MonsterState LoadMonster(MonsterState state, MonsterLoadSelectedAction action) 
            => state with { health = action.Health, name = action.Name };
    }
}
