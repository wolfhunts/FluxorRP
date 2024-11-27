using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListMonster
{
    public class ListMonsterSelectAction
    {
        public ListMonsterSelectAction(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
