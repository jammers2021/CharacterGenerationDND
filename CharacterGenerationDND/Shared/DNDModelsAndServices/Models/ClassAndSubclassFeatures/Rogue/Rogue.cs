using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class Rogue : AllCharacters
	{
		public Rogue() : base() 
		{
			Class = "Rogue";
			LevelOneClassFeature = "Expertise, sneak attack(1d6), Thieves Cant";
			LevelTwoClassFeature = "Cunning Action";
			LevelFiveClassFeature = "Uncanny Dodge, sneak attack(3d6)";
			LevelSixClassFeature = "Expertise";
			LevelSevenClassFeature = "Evasion, sneak attack(4d6)";
			LevelElevenClassFeature = "Reliable Talent, sneak attack(6d6)";
			LevelFourteenClassFeature = "Blindsense";
			LevelFifteenClassFeature = "Slippery mind, sneak attack(8d6)";
			LevelEighteenClassFeature = "Elusive";
			LevelNineteenClassFeature = "Sneak Attack(10d6)";
			LevelTwentyClassFeature = "Stroke of Luck";
		}
		
	}
}
