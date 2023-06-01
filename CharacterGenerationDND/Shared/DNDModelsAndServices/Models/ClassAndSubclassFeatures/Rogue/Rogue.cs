using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class Rogue : IAllCharacters
	{
		public string Class { get; set; } = "Rogue";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Expertise, sneak attack(1d6), Thieves Cant";
		public string? LevelTwoClassFeature { get; set; } = "Cunning Action";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; } = "Uncanny Dodge, sneak attack(3d6)";
		public string? LevelSixClassFeature { get; set; } = "Expertise";
		public string? LevelSevenClassFeature { get; set; } = "Evasion, sneak attack(4d6)";
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; }
		public string? LevelTenClassFeature { get; set; } = null;
		public string? LevelElevenClassFeature { get; set; } = "Reliable Talent, sneak attack(6d6)";
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } 
		public string? LevelFourteenClassFeature { get; set; } = "Blindsense";
		public string? LevelFifteenClassFeature { get; set; } = "Slippery mind, sneak attack(8d6)";
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } 
		public string? LevelEighteenClassFeature { get; set; } = "Elusive";
		public string? LevelNineteenClassFeature { get; set; } = "Sneak Attack(10d6)";
		public string? LevelTwentyClassFeature { get; set; } = "Stroke of Luck";
	}
}
