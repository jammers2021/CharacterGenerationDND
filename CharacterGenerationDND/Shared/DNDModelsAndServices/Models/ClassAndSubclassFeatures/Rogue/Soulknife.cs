using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class Soulknife : Rogue, IAllCharacters
	{
		public string? Subclass = "Soulknife";
		public string? LevelThreeClassFeature = "Psionic Power,Psychic Blades, Sneak Attack(2d6)";
		public string? LevelNineClassFeature = "Soul Blades,Sneak Attack(5d6)";
		public string? LevelThirteenClassFeature = "Psychic Veil, Sneak Attack(7d6)";
		public string? LevelSeventeenClassFeature = "Rend Mind, Sneak Attack(9d6)";
	}
}
