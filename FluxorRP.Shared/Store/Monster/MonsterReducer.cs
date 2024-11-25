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
    }
}
