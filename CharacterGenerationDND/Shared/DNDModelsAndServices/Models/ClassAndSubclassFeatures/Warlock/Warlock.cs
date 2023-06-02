using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock
{
	public class Warlock: AllCharacters
	{
		public Warlock() : base()
		{
			Class = "Warlock";
			LevelTwoClassFeature = "Eldritch Invocations";
			LevelThreeClassFeature = "Pact Boon";
			LevelElevenClassFeature = "Mystic Arcanum (6th Level)-Mental Prison";
			LevelThirteenClassFeature = "Mystic Arcanum (7th Level)-Forcecage";
			LevelFifteenClassFeature = "Mystic Arcanum (8th Level)-Dominant(or Glibness)";
			LevelSeventeenClassFeature = "Mystic Arcanum (9th Level)-Foresight(or true polymorph)";
			LevelTwentyClassFeature = "Eldritch Master";
		}
	}
}
