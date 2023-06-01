using CharacterGenerationDND.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface IHitPointCalculation
    {
        Character CalculateHitPoints(Character character);
    }
}