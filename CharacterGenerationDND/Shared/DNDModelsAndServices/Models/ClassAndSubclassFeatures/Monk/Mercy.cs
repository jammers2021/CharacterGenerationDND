using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class Mercy: Monk, IAllCharacters
	{
		public string? Subclass = "Way of Mercy";
		public string? LevelThreeClassFeature { get; set; } = "Deflect Missiles, (Ki-Fueled Attack-Opt), Hand of Healing, Hand of Harm";
		public string? LevelSixClassFeature { get; set; } = "(Ki-Powered Strikes-Opt.), Physician's Touch";
		public string? LevelElevenClassFeature { get; set; } = "Flurry of Healing and Harm";
		public string? LevelSeventeenClassFeature { get; set; } = "Hands of Ultimate Mercy";
	}
}
