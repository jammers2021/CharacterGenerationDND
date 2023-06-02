using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
    public class Lore: Bard
	{
		public Lore(): base() 
		{
			Subclass = "College of Lore";
			LevelThreeClassFeature = "Expertise, Cutting Words";
			LevelSixClassFeature = "CounterCharm, Additional Magical Secrets";
			LevelFourteenClassFeature = "Magical Secrets, Peerless Skill";
		}
	}
}
