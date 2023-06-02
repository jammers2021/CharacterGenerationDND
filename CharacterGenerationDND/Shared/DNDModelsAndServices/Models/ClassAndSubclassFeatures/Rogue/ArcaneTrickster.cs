using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class ArcaneTrickster : Rogue
	{
		public ArcaneTrickster() : base()
		{
			Subclass = "Arcane Trickster";
			LevelThreeClassFeature = "Mage Hand Legerdemain, Sneak Attack(2d6)";
			LevelNineClassFeature = "Magical Ambush, Sneak Attack(5d6)";
			LevelThirteenClassFeature = "Versatile Trickster, Sneak Attack(7d6)";
			LevelSeventeenClassFeature = "Spell Thief, Sneak Attack(9d6)";
		}
	}
}
