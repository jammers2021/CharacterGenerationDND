using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class ArcaneTrickster: Rogue,IAllCharacters
	{
		public string? Subclass = "Arcane Trickster";
		public string? LevelThreeClassFeature = "Mage Hand Legerdemain, Sneak Attack(2d6)";
		public string? LevelNineClassFeature = "Magical Ambush, Sneak Attack(5d6)";
		public string? LevelThirteenClassFeature = "Versatile Trickster, Sneak Attack(7d6)";
		public string? LevelSeventeenClassFeature = "Spell Thief, Sneak Attack(9d6)";
	}
}
