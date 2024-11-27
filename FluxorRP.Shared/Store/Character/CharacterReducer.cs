using Fluxor;

namespace FluxorRP.Shared.Store.Character
{
    public static class CharacterReducer
    {
        [ReducerMethod]
        public static CharacterState OnAddHealth(CharacterState state, CharacterAddHealthAction action)
            => state with { health = state.health + action.Value };
        [ReducerMethod]
        public static CharacterState LoadCharacter(CharacterState state, CharacterLoadSelectedAction action)
            => state with { health = action.Health, name = action.Name, strength = action.Strength };
    }
}
