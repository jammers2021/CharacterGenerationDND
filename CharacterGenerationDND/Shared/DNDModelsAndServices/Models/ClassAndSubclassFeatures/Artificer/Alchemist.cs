using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
    public class Alchemist : Artificer, IAllCharacters
	{
		public string? Subclass = "Alchemist";
		public string? LevelThreeClassFeature = "Experimental Elixir";
		public string? LevelFiveClassFeature = "Alchemical Savant";
		public string? LevelNineClassFeature = "Restorative Reagents";
		public string? LevelFifteenClassFeature = "Chemical Mastery";
	}
}
