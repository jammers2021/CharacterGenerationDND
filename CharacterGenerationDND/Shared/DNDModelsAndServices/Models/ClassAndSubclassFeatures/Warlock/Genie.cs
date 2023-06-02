using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock
{
	public class Genie : Warlock
	{
		public Genie(): base()
		{
			Subclass = "Genie";
			LevelOneClassFeature = "Genie's Vessel, Genie Kind";
			LevelSixClassFeature = "Elemental Gift";
			LevelTenClassFeature = "Sanctuary Vessel";
			LevelFourteenClassFeature = "Limited Wish";
		}
		
	}
}
