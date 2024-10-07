namespace FluxorRP.Client.Action
{
    public static class Action
    {
        public record RollDiceAction(int RollResult);
        public record MonsterAttackAction(int Damage);

    }
}
