using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer
{
	public class Armorer : Artificer
	{
		public Armorer() : base()
		{
			Subclass = "Armorer";
			LevelThreeClassFeature = "Right Tools for the Job, Heavy Armor Proficiency, Smith's Tools Prof, Arcane Armor, Armor Model";
			LevelFiveClassFeature = "Extra Attack";
			LevelNineClassFeature = "Armor modifications";
			LevelFifteenClassFeature = "Perfected Armor";
		}

	}


}

