using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Wizard
{
	public class Bladesinging: Wizard
	{
		public Bladesinging() : base() 
		{
			Subclass = "Bladesinging";
			LevelTwoClassFeature = "Bladesong";
			LevelSixClassFeature = "Extra Attack";
			LevelTenClassFeature = "Song of Defense";
			LevelFourteenClassFeature = "Song of Victory";
		}
	}
}
