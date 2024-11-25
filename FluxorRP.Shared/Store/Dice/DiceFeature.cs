using Fluxor;

namespace FluxorRP.Shared.Store.Dice
{
    public class DiceFeature : Feature<DiceState>
    {
        public override string GetName() => "Dice state";

        protected override DiceState GetInitialState()
            => new DiceState(0);
    }
}
