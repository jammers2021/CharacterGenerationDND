using CharacterGenerationDND.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface IStrengthPrimaryLevelUp
    {
        Character LevelUpStrength(Character character);
    }
}