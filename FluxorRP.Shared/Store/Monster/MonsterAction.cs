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
}
