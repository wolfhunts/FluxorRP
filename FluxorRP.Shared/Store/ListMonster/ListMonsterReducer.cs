using Fluxor;
using FluxorRP.Shared.Store.ListCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListMonster
{
    public class ListMonsterReducer
    {
        [ReducerMethod]
        public static ListMonsterState OnSelectedMonster(ListMonsterState state, ListMonsterSelectAction action)
            => state with { selectedValue = action.Value };
    }
}
