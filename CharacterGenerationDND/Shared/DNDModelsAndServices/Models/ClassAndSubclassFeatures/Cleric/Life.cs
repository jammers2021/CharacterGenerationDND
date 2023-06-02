using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
	public class Life: Cleric
	{
		public Life() : base()
		{
			Subclass = "Forge";
			LevelOneClassFeature = "Disciple of life";
			LevelTwoClassFeature = "Channel Divinity: Turn Undead + Preserve Life";
			LevelSixClassFeature = "Channel Divinity(X2) + Blessed Healer";
			LevelEightClassFeature = "Destroy Undead(CR=1) + Divine Strike";
			LevelSeventeenClassFeature = "Destroy Undead(CR=4) + Supreme Healer";
		}
	}
}
