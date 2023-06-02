using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
    public class Alchemist : Artificer
	{
		public Alchemist() : base()
		{
			LevelThreeClassFeature = "Experimental Elixir";
			LevelFiveClassFeature = "Alchemical Savant";
			Subclass = "Alchemist";
			LevelNineClassFeature = "Restorative Reagents";
			LevelFifteenClassFeature = "Chemical Mastery";
		}
		
	}
}
