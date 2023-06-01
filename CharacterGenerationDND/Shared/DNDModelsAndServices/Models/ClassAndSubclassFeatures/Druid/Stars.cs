using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid
{
    public class Stars: Druid, IAllCharacters
	{
		public string? Subclass = "Circle of Stars";
		public string? LevelTwoClassFeature = "Star Map";
		public string? LevelSixClassFeature = "Cosmic Omen";
		public string? LevelTenClassFeature = "Twinkling Constellations";
		public string? LevelFourteenClassFeature = "Full of Stars";
	}
}
