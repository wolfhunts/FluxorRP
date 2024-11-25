using Fluxor;

namespace FluxorRP.Shared.Store.Board
{
    public class BoardFeature : Feature<BoardState>
    {
        public override string GetName()
            => $"BoardFeature";

        protected override BoardState GetInitialState()
            => new BoardState(end: false, isPlayerWinner: false);
    }
}
