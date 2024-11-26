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
        private readonly FluxorRPContext _dbContext;
        public ListCharacterFeature(FluxorRPContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected override ListCharacterState GetInitialState()
        {
            var listData = new List<Data.Character>(_dbContext.Characters.ToList());
            return new ListCharacterState(listData, 0);
        } 
    }
}
