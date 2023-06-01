using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface ISpeciesSelection
    {
        Character BaseStatsForCharacterGeneration(Character character);
        Character NameAndSelectSpecies(Character character, string species);
    }
}