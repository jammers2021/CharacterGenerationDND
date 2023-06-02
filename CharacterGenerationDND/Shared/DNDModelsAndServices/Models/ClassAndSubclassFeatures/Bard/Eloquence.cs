using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
	public class Eloquence: Bard
	{
		public Eloquence(): base()
		{
			Subclass = "College of Eloquence";
			LevelThreeClassFeature = "Expertise, Silver Tongue-Persuasion";
			LevelSixClassFeature = "CounterCharm, Unfailing Inspiration, Universal Speech";
			LevelFourteenClassFeature  = "Magical Secrets, Infectious Inspiration";
		}
		
	}
}
