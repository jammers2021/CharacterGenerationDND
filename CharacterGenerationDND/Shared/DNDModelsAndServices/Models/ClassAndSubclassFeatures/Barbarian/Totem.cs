using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian
{
	public class Totem: Barbarian
	{
		public Totem(): base() 
		{
			Subclass = "Path of Totem Warrior";
			LevelThreeClassFeature = "Totem Spirit, (Primal Knowledge-Opt.)";
			LevelSixClassFeature = "Aspect of Beast";
			LevelTenClassFeature = "Spirit Walker";
			LevelFourteenClassFeature = "Totemic attunement";
		}
		
	}
}
