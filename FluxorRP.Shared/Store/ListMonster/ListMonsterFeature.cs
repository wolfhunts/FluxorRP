using Fluxor;
using FluxorRP.Shared.Data;
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
        //private readonly FluxorRPContext _dbContext;

        public override string GetName() => "List Monster state";
        //public ListMonsterFeature(FluxorRPContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        protected override ListMonsterState GetInitialState()
        {
            var listData = new List<Data.Monster>()
            {
                new FluxorRP.Shared.Data.Monster { Id=1, Name = "Gobelin", health=15 },
                new FluxorRP.Shared.Data.Monster { Id=2, Name = "Orc", health =30 },
                new FluxorRP.Shared.Data.Monster { Id=3, Name = "Troll", health =45 }
            };
            return new ListMonsterState(listData, 0);
        }
    }
}
