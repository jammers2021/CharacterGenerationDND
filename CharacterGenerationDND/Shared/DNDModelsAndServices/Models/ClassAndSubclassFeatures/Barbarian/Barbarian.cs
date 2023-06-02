using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian
{
	public class Barbarian : AllCharacters
	{
		public Barbarian() : base()
		{
			Class  = "Barbarian";
			LevelOneClassFeature = "Rage, Unarmored Defense";
			LevelTwoClassFeature = "Reckless Attack, Danger Sense";
			LevelFiveClassFeature = "Extra Attack, Fast Movement";
			LevelSevenClassFeature = "Feral Instinct (Opt. Instinctive Pounce)";
			LevelNineClassFeature = "Brutal Critical (1 Dice)";
			LevelElevenClassFeature = "Relentless Rage";
			LevelThirteenClassFeature = "Brutal Critical (2 Die)";
			LevelFifteenClassFeature = "Persistent Rage";
			LevelSeventeenClassFeature = "Brutal Critical (3 Die)";
			LevelEighteenClassFeature = "Indomitable Might";
			LevelTwentyClassFeature = "Primal Champion";
		}
	}
}
