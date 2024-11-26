using Fluxor;

namespace FluxorRP.Shared.Store.Character
{
        public static class CharacterReducer
        {
            [ReducerMethod]
            public static CharacterState OnAddHealth(CharacterState state, CharacterAddHealthAction action)
                => state with { health = state.health + action.Value };
        }
}
