namespace FluxorRP.Shared.Store.CharacterUseCase;

public record CharacterState(int Health, int Strength, int lastRoll, bool loading);
