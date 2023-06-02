using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
    public class Artificer : AllCharacters
	{
		public Artificer() : base()
		{
			LevelOneClassFeature = "Magical Tinkering";
			LevelTwoClassFeature = "Infuse Item";
			LevelSixClassFeature = "Tool Expertise";
			LevelSevenClassFeature = "Flash of Genius";
			LevelTenClassFeature = "Magic Item Adept";
			LevelElevenClassFeature = "Spell Storing Item";
			LevelFourteenClassFeature = "Magic Item Savant";
			LevelEighteenClassFeature = "Magic Item Master";
			LevelTwentyClassFeature = "Soul of the Artifice";
			Class = "Artificer";
		}
	}
}
