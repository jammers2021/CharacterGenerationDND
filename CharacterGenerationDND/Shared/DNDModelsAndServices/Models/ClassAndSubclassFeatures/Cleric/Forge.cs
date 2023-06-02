using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
    public class Forge: Cleric
	{
		public Forge():base() 
		{
			Subclass = "Forge";
			LevelOneClassFeature = "Blessing of the Forge";
			LevelTwoClassFeature = "Channel Divinity: Turn Undead + Artisans Blessing";
			LevelSixClassFeature = "Channel Divinity(X2) + Soul of the Forge";
			LevelEightClassFeature = "Destroy Undead(CR=1) + Divine Strike";
			LevelSeventeenClassFeature = "Destroy Undead(CR=4) + Saint of Fire and Forge";
		}
	}
}
