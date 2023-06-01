using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Moon : Druid, IAllCharacters
	{
		public string? Subclass = "Circle of Moon";
		public string? LevelTwoClassFeature = "Combat Wild Shape";
		public string? LevelSixClassFeature = "Primal strike";
		public string? LevelTenClassFeature = "Elemental Wild Shape";
		public string? LevelFourteenClassFeature = "Thousand Forms";
	}
}
