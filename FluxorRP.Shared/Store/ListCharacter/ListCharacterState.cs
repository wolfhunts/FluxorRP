using FluxorRP.Shared.Data;
using FluxorRP.Shared.Store.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Store.ListCharacter
{
    public record ListCharacterState(List<Data.Character> Characters, int selectedValue);
}
