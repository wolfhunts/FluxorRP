using FluxorRP.Shared.Store.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListMonster
{
    public record ListMonsterState (List<Data.Monster> Monsters, int selectedValue);
}
