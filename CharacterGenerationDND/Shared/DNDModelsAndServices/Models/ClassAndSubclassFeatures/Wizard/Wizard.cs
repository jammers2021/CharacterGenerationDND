using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Wizard
{
	public class Wizard:AllCharacters
	{

		public string? Class { get; set; } = "Wizard";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Arcane Recovery";
		public string? LevelTwoClassFeature { get; set; }
		public string? LevelThreeClassFeature { get; set; } = "(Cantrip Formulas-Opt.)";
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; } = null;
		public string? LevelSixClassFeature { get; set; } 
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } 
		public string? LevelElevenClassFeature { get; set; } = null;
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } 
		public string? LevelFifteenClassFeature { get; set; } = null;
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } = null;
		public string? LevelEighteenClassFeature { get; set; } = "Spell Mastery";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Signature Spells";
	}
}
