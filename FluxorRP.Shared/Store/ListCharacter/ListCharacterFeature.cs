using Fluxor;
using FluxorRP.Shared.Store.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListCharacter
{
    public class ListCharacterFeature : Feature<ListCharacterState>
    {
        public override string GetName() => "List Character state";

        protected override ListCharacterState GetInitialState()
        {
            using var db = new FluxorRP.Shared.Data.FluxorRPContext();
            var listData = new List<Data.Character>(db.Characters.ToList());
            return new ListCharacterState(listData, 0);
        } 
    }
}
