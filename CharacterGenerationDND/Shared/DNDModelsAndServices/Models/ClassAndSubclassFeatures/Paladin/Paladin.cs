using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Paladin
	{
		public string Class { get; set; } = "Paladin";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Divine Sense, Lay on Hands";
		public string? LevelTwoClassFeature { get; set; } = "Fighting Style, Divine Smite";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack";
		public string? LevelSixClassFeature { get; set; } = "Aura of Protection";
		public string? LevelSevenClassFeature { get; set; } 
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } = "Aura of Courage";
		public string? LevelElevenClassFeature { get; set; } = "Improved Divine Smite";
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } = "Cleansing Touch";
		public string? LevelFifteenClassFeature { get; set; }
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } = null;
		public string? LevelEighteenClassFeature { get; set; } = "Aura Improvements";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } 
	}
}
