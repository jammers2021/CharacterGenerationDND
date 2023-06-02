using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer
{
	public class Sorcerer : AllCharacters
	{
		public Sorcerer() : base() 
		{
			Class = "Sorcerer";
			LevelTwoClassFeature = "Font of Magic";
			LevelThreeClassFeature = "Metamagic";
			LevelFiveClassFeature = "(Magical Guidance-Opt.)";
			LevelTenClassFeature = "Metamagic";
			LevelSeventeenClassFeature = "Metamagic";
			LevelTwentyClassFeature = "Sorcerous Restoration";
		}
	}
}
