using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter
{
	public class Fighter
	{
		public string Class { get; set; } = "Fighter";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Fighting Style, Second Wind";
		public string? LevelTwoClassFeature { get; set; } = "Action Surge";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = "Martial Versatility-Opt";
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack";
		public string? LevelSixClassFeature { get; set; } = "Martial Versatility-Opt";
		public string? LevelSevenClassFeature { get; set; }
		public string? LevelEightClassFeature { get; set; } = "Wild Shape Improvement";
		public string? LevelNineClassFeature { get; set; } = "Indomitable";
		public string? LevelTenClassFeature { get; set; }
		public string? LevelElevenClassFeature { get; set; } = "Extra Attack(X2)";
		public string? LevelTwelveClassFeature { get; set; } = "Martial Versatility-Opt";
		public string? LevelThirteenClassFeature { get; set; } = "Indomitable(X2)";
		public string? LevelFourteenClassFeature { get; set; } = "Martial Versatility-Opt.";
		public string? LevelFifteenClassFeature { get; set; } 
		public string? LevelSixteenClassFeature { get; set; } = "Martial Versatility-Opt.";
		public string? LevelSeventeenClassFeature { get; set; } = "Action Surge(X2), Indomitable(X3)";
		public string? LevelEighteenClassFeature { get; set; }
		public string? LevelNineteenClassFeature { get; set; } = "Martial Versatility-Opt.";
		public string? LevelTwentyClassFeature { get; set; } = "Extra Attack(X3)";
	}
}
