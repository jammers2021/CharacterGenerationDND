using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer
{
	public class ShadowMagic: Sorcerer
	{
		public ShadowMagic() : base()
		{
			Subclass = "Shadow Magic";
			LevelOneClassFeature = "Eyes of the Dark, Strength of the Grave";
			LevelSixClassFeature = "Hound of Ill Omen";
			LevelFourteenClassFeature = "Shadow Walk";
			LevelEighteenClassFeature = "Umbral Form";
		}
	}
}
