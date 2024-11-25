namespace FluxorRP.Shared.Store.Character
{
    public class CharacterAddHealthAction
    {
        public CharacterAddHealthAction(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }	
}
