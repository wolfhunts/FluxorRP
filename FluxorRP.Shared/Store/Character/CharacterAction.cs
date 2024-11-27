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
    
    public class CharacterLoadSelectedAction
    {
        public string Name { get; }
        public int Health { get; }
        public int Strength { get; }
        public CharacterLoadSelectedAction(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }
    }
}
