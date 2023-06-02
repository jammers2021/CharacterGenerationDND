using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Wizard
{
	public class Scribes: Wizard
	{
		public Scribes() : base()
		{
			Subclass = "Order of the Scribes";
			LevelTwoClassFeature = "Wizardly Quill, Awakened Spellbook";
			LevelSixClassFeature = "Manifest Mind";
			LevelTenClassFeature = "Master Scrivener";
			LevelFourteenClassFeature = "One with the Word";
		}
	}
}
