using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock
{
	public class Hexblade: Warlock,IAllCharacters
	{
		public string? Subclass = "Hexblade";
		public string? LevelOneClassFeature = "Hex Warrior";
		public string? LevelSixClassFeature = "Accursed Specter";
		public string? LevelTenClassFeature = "Armor of Hexes";
		public string? LevelFourteenClassFeature = "Master of Hexes";

	}
}
