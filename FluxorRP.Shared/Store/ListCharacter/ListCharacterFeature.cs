using Fluxor;
using FluxorRP.Shared.Data;
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
            var listData = new List<Data.Character>()
            {
                new FluxorRP.Shared.Data.Character { Id =1, Name = "Jeune aventurier", health = 20, strength = 5 },
                new FluxorRP.Shared.Data.Character { Id = 2,Name = "Aventurier confirmé", health = 40, strength = 15 },
                new FluxorRP.Shared.Data.Character { Id = 3,Name = "Vétéran", health = 80, strength = 25 }
            };
            return new ListCharacterState(listData, 0);
        } 
    }
}
