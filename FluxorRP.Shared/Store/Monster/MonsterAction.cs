namespace FluxorRP.Shared.Store.Monster
{
    public class MonsterLaunchAttackAction
    {
    }

    public class MonsterAttackAction
    {
        public MonsterAttackAction(int point)
        {
            Point = point;
        }

        public int Point { get; }
    }
    public class MonsterLoadSelectedAction
    {
        public string Name { get; }
        public int Health { get; }
        public int Strength { get; }
        public MonsterLoadSelectedAction(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
