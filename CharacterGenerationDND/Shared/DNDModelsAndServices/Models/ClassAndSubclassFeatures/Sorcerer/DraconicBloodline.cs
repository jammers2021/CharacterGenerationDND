using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer
{
	public class DraconicBloodline: Sorcerer
	{
		public DraconicBloodline():base()
		{
			Subclass = "Draconic Bloodline";
			LevelOneClassFeature = "Dragon Ancestor, Draconic Resistance";
			LevelSixClassFeature = "Elemental Affinity";
			LevelFourteenClassFeature = "Dragon Wings";
			LevelEighteenClassFeature = "Draconic Presence";
		}
	}
}
