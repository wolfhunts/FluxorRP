using Fluxor;
using FluxorRP.Client.Class;
using static System.Net.Mime.MediaTypeNames;

namespace FluxorRP.Client
{
    public class Init
    {
    }
    public class CharacterFeature : Feature<CharacterState>
    {
        public override string GetName() => "Character";
        protected override CharacterState GetInitialState() => new CharacterState(100,10);
    }

    public class MonsterFeature : Feature<MonsterState>
    {
        public override string GetName() => "Monster";
        protected override MonsterState GetInitialState() => new MonsterState(50,10);
    }

}
