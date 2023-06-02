using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue
{
	public class Soulknife : Rogue
	{
		public Soulknife() : base() 
		{
			Subclass = "Soulknife";
			LevelThreeClassFeature = "Psionic Power,Psychic Blades, Sneak Attack(2d6)";
			LevelNineClassFeature = "Soul Blades,Sneak Attack(5d6)";
			LevelThirteenClassFeature = "Psychic Veil, Sneak Attack(7d6)";
			LevelSeventeenClassFeature = "Rend Mind, Sneak Attack(9d6)";
		}	
	}
}
