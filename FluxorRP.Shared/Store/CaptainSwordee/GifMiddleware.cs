using Fluxor;
using FluxorRP.Shared.Store.Dice;

namespace FluxorRP.Shared.Store.CaptainSwordee
{
    public class GifMiddleware : Middleware
    {
        private readonly IDispatcher _dispatcher;
        public GifMiddleware(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public override void AfterDispatch(object action)
        {
            if (action is DiceRollAction)
            {
                _dispatcher.Dispatch(new GifAction());
            }
        }
    }
}
