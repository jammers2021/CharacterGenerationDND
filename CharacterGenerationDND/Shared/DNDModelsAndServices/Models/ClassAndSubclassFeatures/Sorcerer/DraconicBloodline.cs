using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer
{
	public class DraconicBloodline: Sorcerer,IAllCharacters
	{
		public string? Subclass = "Draconic Bloodline";
		public string? LevelOneClassFeature = "Dragon Ancestor, Draconic Resistance";
		public string? LevelSixClassFeature = "Elemental Affinity";
		public string? LevelFourteenClassFeature = "Dragon Wings";
		public string? LevelEighteenClassFeature = "Draconic Presence";
	}
}
