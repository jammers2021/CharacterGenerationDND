using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models;
using static CharacterGenerationDND.DNDModelsAndServices.Models.CharacterClassSelection;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface ICharacterFactory
    {
        Character CreateCharacter(ClassSelection classState, int level, string? subclass, int classVariant, string species, List<int> stats);
    }
}