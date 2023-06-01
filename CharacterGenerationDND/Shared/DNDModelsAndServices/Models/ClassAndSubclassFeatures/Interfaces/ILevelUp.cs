using CharacterGenerationDND.DNDModelsAndServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface ILevelUp
    {
        Character StandardFeat(Character character);
        Character FighterFeat(Character character);
        Character RogueFeat(Character character);
    }
}
