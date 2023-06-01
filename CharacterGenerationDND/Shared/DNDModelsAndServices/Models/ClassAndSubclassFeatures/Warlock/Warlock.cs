using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock
{
	public class Warlock
	{
		public string? Class { get; set; } = "Warlock";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; }
		public string? LevelTwoClassFeature { get; set; } = "Eldritch Invocations";
		public string? LevelThreeClassFeature { get; set; } = "Pact Boon";
		public string? LevelFourClassFeature { get; set; } = "(Eldritch Versatility-Opt.)";
		public string? LevelFiveClassFeature { get; set; } = null;
		public string? LevelSixClassFeature { get; set; }
		public string? LevelSevenClassFeature { get; set; } = null;
		public string? LevelEightClassFeature { get; set; } = "(Eldritch Versatility-Opt.)";
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } 
		public string? LevelElevenClassFeature { get; set; } ="Mystic Arcanum (6th Level)-Mental Prison";
		public string? LevelTwelveClassFeature { get; set; } = "(Eldritch Versatility-Opt.)";
		public string? LevelThirteenClassFeature { get; set; } = "Mystic Arcanum (7th Level)-Forcecage";
		public string? LevelFourteenClassFeature { get; set; }
		public string? LevelFifteenClassFeature { get; set; } = "Mystic Arcanum (8th Level)-Dominant(or Glibness)";
		public string? LevelSixteenClassFeature { get; set; } = "(Eldritch   Versatility-Opt.)";
		public string? LevelSeventeenClassFeature { get; set; } = "Mystic Arcanum (9th Level)-Foresight(or true polymorph)";
		public string? LevelEighteenClassFeature { get; set; } = null;
		public string? LevelNineteenClassFeature { get; set; } = "(Eldritch Versatility-Opt.)";
		public string? LevelTwentyClassFeature { get; set; } = "Eldritch Master";
	}
}
