using Fluxor;
using FluxorRP.Shared.Store.ListCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListMonster
{
    public class ListMonsterFeature : Feature<ListMonsterState>
    {
        public override string GetName() => "List Monster state";

        protected override ListMonsterState GetInitialState()
        {
            using var db = new FluxorRP.Shared.Data.FluxorRPContext();
            var listData = new List<Data.Monster>(db.Monsters.ToList());
            return new ListMonsterState(listData, 0);
        }
    }
}
