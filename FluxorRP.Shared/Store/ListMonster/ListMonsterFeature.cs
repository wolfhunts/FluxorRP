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
        private readonly FluxorRPContext _dbContext;

        public override string GetName() => "List Monster state";
        public ListMonsterFeature(FluxorRPContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected override ListMonsterState GetInitialState()
        {
            var listData = new List<Data.Monster>(_dbContext.Monsters.ToList());
            return new ListMonsterState(listData, 0);
        }
    }
}
