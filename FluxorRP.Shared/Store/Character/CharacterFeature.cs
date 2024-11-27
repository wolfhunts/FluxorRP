using Fluxor;

namespace FluxorRP.Shared.Store.Character
{
    public class CharacterFeature : Feature<CharacterState>
    {
        public override string GetName()
            => "ChracterHealth";

        protected override CharacterState GetInitialState()
            => new CharacterState(name: "Jd", health: 10, strength: 5);
    }
}
