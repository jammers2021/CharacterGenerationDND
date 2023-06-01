using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin
{
	public class Vengeance : Paladin, IAllCharacters
	{
		public string? Subclass = "Oath of Vengeance";
		public string? LevelThreeClassFeature { get; set; } = "Channel Divinity: Abjure Enemy + Vow of Enmity";
		public string? LevelSevenClassFeature { get; set; } = "Relentless Avenger";
		public string? LevelFifteenClassFeature { get; set; } = "Soul of Vengeance";
		public string? LevelTwentyClassFeature { get; set; } = "Avenging Angel";
	}
}
