using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Ranger
{
	public class Gloomstalker : Ranger	
	{
		public Gloomstalker() : base() 
		{
			Subclass = "Gloomstalker";
			LevelThreeClassFeature = "Dread Ambusher, Umbral Sight";
			LevelSevenClassFeature = "Iron mind";
			LevelElevenClassFeature = "Stalker's Flurry";
			LevelFifteenClassFeature = "Shadowy Dodge";
		}
	}
}
