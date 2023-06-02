using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Vengeance : Paladin
	{ 
		public Vengeance() : base() 
		{
			Subclass = "Oath of Vengeance";
			LevelThreeClassFeature = "Channel Divinity: Abjure Enemy + Vow of Enmity";
			LevelSevenClassFeature = "Relentless Avenger";
			LevelFifteenClassFeature = "Soul of Vengeance";
			LevelTwentyClassFeature = "Avenging Angel";
		}
	}
}
