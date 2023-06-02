using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
    public class Cleric: AllCharacters
	{
		public Cleric():base() 
		{
			Class = "Cleric";
			LevelFiveClassFeature = "Destroy Undead (CR 1/2)";
			LevelNineClassFeature = "Song of Rest(d8)";
			LevelTenClassFeature = "Divine Inspiration";
			LevelElevenClassFeature = "Destroy Undead (CR-2)";
			LevelFourteenClassFeature = "Destroy Undead (CR-3)";
			LevelEighteenClassFeature = "Channel Divinity (X3)";
			LevelTwentyClassFeature = "Divine Intervention Improvement";
		}
		
	}
}
