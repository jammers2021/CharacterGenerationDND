using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Druid : IAllCharacters
	{
		public string Class { get; set; } = "Druid";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Druidic";
		public string? LevelTwoClassFeature { get; set; }
		public string? LevelThreeClassFeature { get; set; } = null;
		public string? LevelFourClassFeature { get; set; } = "Wild Shape Improvement";
		public string? LevelFiveClassFeature { get; set; } = null;
		public string? LevelSixClassFeature { get; set; }
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } = "Wild Shape Improvement";
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } 
		public string? LevelElevenClassFeature { get; set; } = null;
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } 
		public string? LevelFifteenClassFeature { get; set; } = null;
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } = null;
		public string? LevelEighteenClassFeature { get; set; } = "Timeless Body, Beast Spells";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Archdruid";
	}
}
