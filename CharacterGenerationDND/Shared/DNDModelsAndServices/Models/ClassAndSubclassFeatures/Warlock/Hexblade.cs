using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock
{
	public class Hexblade: Warlock
	{
		public Hexblade(): base() 
		{
			Subclass = "Hexblade";
			LevelOneClassFeature = "Hex Warrior";
			LevelSixClassFeature = "Accursed Specter";
			LevelTenClassFeature = "Armor of Hexes";
			LevelFourteenClassFeature = "Master of Hexes";
		}
	}
}
