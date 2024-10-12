namespace FluxorRP.Client.Class
{
    public record CharacterState(int Health, int Strength, int lastRoll, bool loading);

    public record MonsterState(int Health, int Domage);

}
