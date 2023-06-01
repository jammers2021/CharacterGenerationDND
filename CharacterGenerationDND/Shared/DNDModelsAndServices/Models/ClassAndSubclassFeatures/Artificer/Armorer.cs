using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
    public class Armorer : Artificer, IAllCharacters
	{
		public string? Subclass = "Armorer";
		public string? LevelThreeClassFeature = "Right Tools for the Job, Heavy Armor Proficiency, Smith's Tools Prof, Arcane Armor, Armor Model";
		public string? LevelFiveClassFeature = "Extra Attack";
		public string? LevelNineClassFeature = "Armor modifications";
		public string? LevelFifteenClassFeature = "Perfected Armor";
	}
	

}
	
