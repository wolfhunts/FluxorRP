using Fluxor;

namespace FluxorRP.Shared.Store.Board
{
    public static class BoardReducer
    {
        [ReducerMethod]
        public static BoardState EndOfGame(BoardState state, BoardEndOfGameAction action)
            => state with { end = action.End, isPlayerWinner = action.IsPlayerWinner };
    }
}
