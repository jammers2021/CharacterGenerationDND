using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Crown: Paladin
	{
		public Crown() : base() 
		{
			Subclass = "Oath of the Crown";
			LevelThreeClassFeature = "Channel Divinity: Champion Challenge + Turn the Tide";
			LevelSevenClassFeature = "Divine Allegiance";
			LevelFifteenClassFeature = "Unyielding Saint";
			LevelTwentyClassFeature = "Exalted Champion";
		}
		
	}
}
