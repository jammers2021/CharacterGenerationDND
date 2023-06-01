using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer
{
	public class Sorcerer : IAllCharacters
	{
		public string Class { get; set; } = "Sorcerer";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; }
		public string? LevelTwoClassFeature { get; set; } = "Font of Magic";
		public string? LevelThreeClassFeature { get; set; } = "Metamagic";
		public string? LevelFourClassFeature { get; set; } = "(Sorcerous Versatility-Opt.)";
		public string? LevelFiveClassFeature { get; set; } = "(Magical Guidance-Opt.)";
		public string? LevelSixClassFeature { get; set; } 
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } = "(Sorcerous Versatility-Opt.)";
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } = "Metamagic";
		public string? LevelElevenClassFeature { get; set; } = null;
		public string? LevelTwelveClassFeature { get; set; } = "(Sorcerous Versatility-Opt.)";
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } 
		public string? LevelFifteenClassFeature { get; set; } = null;
		public string? LevelSixteenClassFeature { get; set; } = "(Sorcerous Versatility-Opt.)";
		public string? LevelSeventeenClassFeature { get; set; } = "Metamagic";
		public string? LevelEighteenClassFeature { get; set; } 
		public string? LevelNineteenClassFeature { get; set; } = "(Sorcerous Versatility-Opt.)";
		public string? LevelTwentyClassFeature { get; set; } = "Sorcerous Restoration";
	}
}
