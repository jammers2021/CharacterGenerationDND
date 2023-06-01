using CharacterGenerationDND.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface IChosenClassSelection
    {
        CharacterClassSelection.ClassSelection SelectClass(string className);
    }
}