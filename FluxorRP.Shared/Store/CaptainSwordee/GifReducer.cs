using Fluxor;

namespace FluxorRP.Shared.Store.CaptainSwordee
{
    public static class GifReducer
    {
        [ReducerMethod]
        public static GifState ReduceShowImageAction(GifState state, GifAction action)
        {
            return state with { IsImageVisible = (state.IsImageVisible) ? false : true };
        }
    }

}
