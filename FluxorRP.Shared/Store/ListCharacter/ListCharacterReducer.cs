using Fluxor;
using FluxorRP.Shared.Store.Dice;
using FluxorRP.Shared.Store.ListCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListCharacter
{
    public class ListCharacterReducer
    {
        [ReducerMethod]
        public static ListCharacterState OnSelectedCharacter(ListCharacterState state, ListCharacterSelectAction action)
            => state with { selectedValue = action.Value };
        
    }
}
