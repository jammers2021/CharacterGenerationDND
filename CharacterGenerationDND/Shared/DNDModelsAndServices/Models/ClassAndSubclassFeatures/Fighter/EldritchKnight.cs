using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter
{
	public class EldritchKnight: Fighter
	{
		public EldritchKnight() : base()
		{
			Subclass = "Eldritch Knight";
			LevelThreeClassFeature = "Weapon Bond, Spellcasting(Int)";
			LevelSevenClassFeature = "War Magic";
			LevelTenClassFeature = "Eldritch Strike";
			LevelFifteenClassFeature = "Arcane Charge";
			LevelEighteenClassFeature = "Improved War Magic";
		}
		
	}
}
