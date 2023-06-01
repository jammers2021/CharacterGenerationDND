using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class AstralSelf:Monk,IAllCharacters
	{
		public string? Subclass = "Way of Astral Self";
		public string? LevelThreeClassFeature = "Deflect Missiles, (Ki-Fueled Attack-Opt), Arms of the Astral Self";
		public string? LevelSixClassFeature = "(Ki-Powered Strikes-Opt.), Visage of Astral Self";
		public string? LevelElevenClassFeature = "Body of Astral Self";
		public string? LevelSeventeenClassFeature = "Awakened Astral Self";
	}
}
