namespace FluxorRP.Client.Action
{
    public static class Action
    {
        public record RollDiceAction();
        public record RollDiceActionResult(int roll);
        public record MonsterAttackAction(int Damage);
        
    }
}
