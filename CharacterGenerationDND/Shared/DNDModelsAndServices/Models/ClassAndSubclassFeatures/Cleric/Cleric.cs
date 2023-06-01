using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
    public class Cleric: IAllCharacters
	{
		public string Class { get; set; } = "Cleric";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; }
		public string? LevelTwoClassFeature { get; set; } 
		public string? LevelThreeClassFeature { get; set; } = null;
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; } = "Destroy Undead (CR 1/2)";
		public string? LevelSixClassFeature { get; set; } 
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } 
		public string? LevelNineClassFeature { get; set; } = "Song of Rest(d8)";
		public string? LevelTenClassFeature { get; set; } = "Divine Inspiration";
		public string? LevelElevenClassFeature { get; set; } = "Destroy Undead (CR-2)";
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } = "Destroy Undead (CR-3)";
		public string? LevelFifteenClassFeature { get; set; } = null;
		public string? LevelSixteenClassFeature { get; set; } 
		public string? LevelSeventeenClassFeature { get; set; }
		public string? LevelEighteenClassFeature { get; set; } = "Channel Divinity (X3)";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Divine Intervention Improvement";
	}
}
