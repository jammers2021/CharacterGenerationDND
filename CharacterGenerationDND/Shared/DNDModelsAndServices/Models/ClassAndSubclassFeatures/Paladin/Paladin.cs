using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Paladin : AllCharacters
	{
		public Paladin() : base()
		{
			Class = "Paladin";
			LevelOneClassFeature = "Divine Sense, Lay on Hands";
			LevelTwoClassFeature = "Fighting Style, Divine Smite";
			LevelFiveClassFeature = "Extra Attack";
			LevelSixClassFeature = "Aura of Protection";
			LevelTenClassFeature = "Aura of Courage";
			LevelElevenClassFeature = "Improved Divine Smite";
			LevelFourteenClassFeature = "Cleansing Touch";
			LevelEighteenClassFeature = "Aura Improvements";
		}
	}
}
