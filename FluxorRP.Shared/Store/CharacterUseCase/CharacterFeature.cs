using Fluxor;

namespace FluxorRP.Shared.Store.CharacterUseCase;

public class CharacterFeature : Feature<CharacterState>
{
    public override string GetName() => "Character";
    protected override CharacterState GetInitialState() => new CharacterState(100, 10, 0, false);
}
