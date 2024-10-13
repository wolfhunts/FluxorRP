using Fluxor;

namespace FluxorRP.Shared.Store.MonsterUseCase;

public class MonsterFeature : Feature<MonsterState>
{
    public override string GetName() => "Monster";
    protected override MonsterState GetInitialState() => new MonsterState(50, 10);
}
