using Fluxor;

namespace FluxorRP.Shared.Store.MonsterUseCase;

public class Reducer
{
    [ReducerMethod]
    public MonsterState ReduceMonsterAttack(MonsterState state, MonsterAttackAction action)
        => state with { Health = state.Health - action.Damage };
}
