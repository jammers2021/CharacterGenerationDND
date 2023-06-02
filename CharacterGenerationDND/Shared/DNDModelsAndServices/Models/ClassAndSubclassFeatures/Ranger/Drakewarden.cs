using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Ranger
{
	public class Drakewarden: Ranger
	{
		public Drakewarden() : base()
		{
			Subclass = "Drakewarden";
			LevelThreeClassFeature = "Draconic Gift, Drake Companion";
			LevelSevenClassFeature = "Bond of Fang and Scale";
			LevelElevenClassFeature = "Drake's Breath";
			LevelFifteenClassFeature = "Perfected Bond";
		}
	}
}
