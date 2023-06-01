using CharacterGenerationDND.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
	public interface IStrengthPrimaryLevelUp
	{
		Character LevelUpStrength(Character character);
	}
}