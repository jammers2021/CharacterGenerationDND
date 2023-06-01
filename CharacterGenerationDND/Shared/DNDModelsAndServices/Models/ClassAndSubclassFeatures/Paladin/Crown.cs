using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Crown:Paladin, IAllCharacters
	{
		public string? Subclass = "Oath of the Crown";
		public string? LevelThreeClassFeature = "Channel Divinity: Champion Challenge + Turn the Tide";
		public string? LevelSevenClassFeature = "Divine Allegiance";
		public string? LevelFifteenClassFeature = "Unyielding Saint";
		public string? LevelTwentyClassFeature = "Exalted Champion";
	}
}
