using Fluxor;

namespace FluxorRP.Shared.Store.CaptainSwordee;
    public class GifStateFeature : Feature<GifState>
    {
        public override string GetName() => "GifState"; // nom de la feature

        protected override GifState GetInitialState() =>
            new GifState(false); // Initialisez votre état avec les valeurs par défaut
    }
