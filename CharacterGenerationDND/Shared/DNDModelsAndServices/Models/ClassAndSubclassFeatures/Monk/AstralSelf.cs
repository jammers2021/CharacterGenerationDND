using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class AstralSelf: Monk
	{
		public AstralSelf() :base() 
		{
			Subclass = "Way of Astral Self";
			LevelThreeClassFeature = "Deflect Missiles, (Ki-Fueled Attack-Opt), Arms of the Astral Self";
			LevelSixClassFeature = "(Ki-Powered Strikes-Opt.), Visage of Astral Self";
			LevelElevenClassFeature = "Body of Astral Self";
			LevelSeventeenClassFeature = "Awakened Astral Self";
		}
	}
}
