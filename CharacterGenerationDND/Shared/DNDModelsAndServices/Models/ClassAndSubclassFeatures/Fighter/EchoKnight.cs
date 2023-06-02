using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter
{
	public class EchoKnight: Fighter
	{
		public EchoKnight() : base() 
		{
			Subclass = "Echo Knight";
			LevelThreeClassFeature = "Manifest Echo";
			LevelSevenClassFeature = "Echo Avatar";
			LevelTenClassFeature = "Shadow Martyr";
			LevelFifteenClassFeature = "Reclaim Potential";
			LevelEighteenClassFeature = "Legion of One";
		}
	}
}
