using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
    public class Bard : IAllCharacters
	{
		public string Class { get; set; } = "Bard";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Bardic Inspiration(d6)";
		public string? LevelTwoClassFeature { get; set; } = "Jack of All Trades, Song of Rest(d6), (Magical Inspiration-Opt)";
		public string? LevelThreeClassFeature { get ; set ; }
		public string? LevelFourClassFeature { get; set; } = "(Bardic Versatility-Opt.)";
		public string? LevelFiveClassFeature { get; set; } = "Font of Inspiration, Bardic Inspiration(d8)";
		public string? LevelSixClassFeature { get; set; } 
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } = "(Bardic Versatility-Opt.)";
		public string? LevelNineClassFeature { get; set; } = "Song of Rest(d8)";
		public string? LevelTenClassFeature { get; set; } = "Bardic Inspiration(d10), Expertise, Magical Secrets";
		public string? LevelElevenClassFeature { get ; set ; } = null;
		public string? LevelTwelveClassFeature { get; set; } = "(Bardic Versatility-Opt.)";
		public string? LevelThirteenClassFeature { get; set; } = "Song of Rest (d10)";
		public string? LevelFourteenClassFeature { get ; set ; }
		public string? LevelFifteenClassFeature { get; set; } = "Bardic Inspiration (d12)";
		public string? LevelSixteenClassFeature { get; set; }
		public string? LevelSeventeenClassFeature { get; set; } = "Song of Rest (d12)";
		public string? LevelEighteenClassFeature { get; set; } = "Magical Secrets";
		public string? LevelNineteenClassFeature { get; set; } = "(Bardic Versatility-Opt.)";
		public string? LevelTwentyClassFeature { get; set; } = "Superior Inspiration";
		
	}
}
