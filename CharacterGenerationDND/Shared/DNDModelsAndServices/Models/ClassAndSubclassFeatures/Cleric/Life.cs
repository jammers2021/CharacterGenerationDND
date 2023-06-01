using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
	public class Life
	{
		public string? Subclass { get; set; } = "Forge";
		public string? LevelOneClassFeature = "Disciple of life";
		public string? LevelTwoClassFeature = "Channel Divinity: Turn Undead + Preserve Life";
		public string? LevelSixClassFeature = "Channel Divinity(X2) + Blessed Healer";
		public string? LevelEightClassFeature = "Destroy Undead(CR=1) + Divine Strike";
		public string? LevelSeventeenClassFeature = "Destroy Undead(CR=4) + Supreme Healer";
	}
}
