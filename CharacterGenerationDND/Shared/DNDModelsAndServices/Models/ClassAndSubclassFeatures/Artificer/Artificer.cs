using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
    public class Artificer : IAllCharacters
	{
		public string? LevelOneClassFeature { get; set; } = "Magical Tinkering";
		public string? LevelTwoClassFeature { get; set; } = "Infuse Item";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = null;
		public string? LevelFiveClassFeature { get; set; }
		public string? LevelSixClassFeature { get; set; } = "Tool Expertise";
		public string? LevelSevenClassFeature { get; set; } = "Flash of Genius";
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; }
		public string? LevelTenClassFeature { get; set; } = "Magic Item Adept";
		public string? LevelElevenClassFeature { get; set; } = "Spell Storing Item";
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } = "Magic Item Savant";
		public string? LevelFifteenClassFeature { get; set; }
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; } = null;
		public string? LevelEighteenClassFeature { get; set; } = "Magic Item Master";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Soul of the Artifice";
		public string Class { get; set; } = "Artificer";
		public string? Subclass { get ; set ; }
	}
}
