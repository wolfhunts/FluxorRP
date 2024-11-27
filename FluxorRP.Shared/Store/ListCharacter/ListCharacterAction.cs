using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListCharacter
{
    public class ListCharacterSelectAction
    {
        public ListCharacterSelectAction(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
