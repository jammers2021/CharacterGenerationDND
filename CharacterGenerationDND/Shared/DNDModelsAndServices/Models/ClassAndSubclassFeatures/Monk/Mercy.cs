using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class Mercy: Monk
	{
		public Mercy() : base() 
		{
			Subclass = "Way of Mercy";
			LevelThreeClassFeature = "Deflect Missiles, (Ki-Fueled Attack-Opt), Hand of Healing, Hand of Harm";
			LevelSixClassFeature = "(Ki-Powered Strikes-Opt.), Physician's Touch";
			LevelElevenClassFeature = "Flurry of Healing and Harm";
			LevelSeventeenClassFeature = "Hands of Ultimate Mercy";
		}
	}
}
