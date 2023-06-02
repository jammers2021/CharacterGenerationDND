using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Moon : Druid
	{
		public Moon():base() 
		{
			Subclass = "Circle of Moon";
			LevelTwoClassFeature = "Combat Wild Shape";
			LevelSixClassFeature = "Primal strike";
			LevelTenClassFeature = "Elemental Wild Shape";
			LevelFourteenClassFeature = "Thousand Forms";
		}
	}
}
