using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
    public class Lore:Bard,IAllCharacters
	{
		public string? Subclass { get; set; } = "College of Lore";
		public string? LevelThreeClassFeature { get; set; } = "Expertise, Cutting Words";
		public string? LevelSixClassFeature { get; set; } = "CounterCharm, Additional Magical Secrets";
		public string? LevelFourteenClassFeature { get; set; } = "Magical Secrets, Peerless Skill";

	}
}
