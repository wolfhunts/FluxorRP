namespace FluxorRP.Shared.Store.Board
{
    public class BoardEndOfGameAction
    {
        public BoardEndOfGameAction(bool end, bool isPlayerWinner)
        {
            End = end;
            IsPlayerWinner = isPlayerWinner;
        }

        public bool End { get; }
        public bool IsPlayerWinner { get; }
    }
}
