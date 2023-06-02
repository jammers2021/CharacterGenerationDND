using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Stars: Druid
	{
		public Stars() : base() 
		{
			Subclass = "Circle of Stars";
			LevelTwoClassFeature = "Star Map";
			LevelSixClassFeature = "Cosmic Omen";
			LevelTenClassFeature = "Twinkling Constellations";
			LevelFourteenClassFeature = "Full of Stars";
		}
	}
}
