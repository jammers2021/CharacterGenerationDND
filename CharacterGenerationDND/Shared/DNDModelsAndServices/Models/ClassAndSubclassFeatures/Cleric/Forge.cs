using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric
{
    public class Forge:Cleric,IAllCharacters
	{
		public string? Subclass { get; set; } = "Forge";
		public string? LevelOneClassFeature = "Blessing of the Forge";
		public string? LevelTwoClassFeature = "Channel Divinity: Turn Undead + Artisan's Blessing";
		public string? LevelSixClassFeature = "Channel Divinity(X2) + Soul of the Forge";
		public string? LevelEightClassFeature = "Destroy Undead(CR=1) + Divine Strike";
		public string? LevelSeventeenClassFeature = "Destroy Undead(CR=4) + Saint of Fire and Forge";
	}
}
