using Fluxor;

namespace FluxorRP.Shared.Store.Monster
{
    public class MonsterFeature : Feature<MonsterState>
    {
        public override string GetName() => "MonsterHealth";

        protected override MonsterState GetInitialState()
            => new MonsterState(name : "Goblin",health: 200);
    }
}
