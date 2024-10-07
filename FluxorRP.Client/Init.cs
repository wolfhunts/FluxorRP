using Fluxor;
using FluxorRP.Client.Class;

namespace FluxorRP.Client
{
    public class Init
    {
    }
    public class CharacterFeature : Feature<CharacterState>
    {
        public override string GetName() => "Character";
        protected override CharacterState GetInitialState() => new CharacterState { Health = 100, Strength = 10 };
    }

    public class MonsterFeature : Feature<MonsterState>
    {
        public override string GetName() => "Monster";
        protected override MonsterState GetInitialState() => new MonsterState { Health = 50 };
    }

}
