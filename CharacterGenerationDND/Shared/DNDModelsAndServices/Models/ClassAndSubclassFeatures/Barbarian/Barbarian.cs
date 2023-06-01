using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian
{
    public class Barbarian : IAllCharacters
	{
		public string Class { get; set; } = "Barbarian";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get ; set ; } = "Rage, Unarmored Defense";
		public string? LevelTwoClassFeature { get; set; } = "Reckless Attack, Danger Sense";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack, Fast Movement";
		public string? LevelSixClassFeature { get; set; }
		public string? LevelSevenClassFeature { get; set; } = "Feral Instinct (Opt. Instinctive Pounce)";
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; } = "Brutal Critical (1 Dice)";
		public string? LevelTenClassFeature { get; set; }
		public string? LevelElevenClassFeature { get; set; } = "Relentless Rage";
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = "Brutal Critical (2 Die)";
		public string? LevelFourteenClassFeature { get; set; }
		public string? LevelFifteenClassFeature { get; set; } = "Persistent Rage";
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } = "Brutal Critical (3 Die)";
		public string? LevelEighteenClassFeature { get; set; } = "Indomitable Might";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Primal Champion";
	}
}
