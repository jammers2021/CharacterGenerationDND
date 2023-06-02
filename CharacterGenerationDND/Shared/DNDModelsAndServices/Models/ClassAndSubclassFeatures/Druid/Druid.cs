using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Druid : AllCharacters
	{
		public Druid():base() 
		{
			Class = "Druid";
			LevelOneClassFeature = "Druidic";
			LevelFourClassFeature = "Wild Shape Improvement";
			LevelEightClassFeature = "Wild Shape Improvement";
			LevelEighteenClassFeature = "Timeless Body, Beast Spells";
			LevelTwentyClassFeature = "Archdruid";
		}
		
	}
}
