using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class Monk:IAllCharacters
	{
		public string Class { get; set; } = "Monk";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Unarmored Defense, Martial Arts";
		public string? LevelTwoClassFeature { get; set; } = "Ki, Unarmored Movement, (Dedicated Weapon-Opt.)";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } = "Slow Fall, (Quickened Healing-Opt.)";
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack, Stunning Strike, (Focused Aim-Opt.)";
		public string? LevelSixClassFeature { get; set; } = "Martial Versatility-Opt";
		public string? LevelSevenClassFeature { get; set; } = "Evasion, Stillness of Mind";
		public string? LevelEightClassFeature { get; set; } = null;
		public string? LevelNineClassFeature { get; set; } = "Unarmored Movement Improvement";
		public string? LevelTenClassFeature { get; set; } = "Purity of Body";
		public string? LevelElevenClassFeature { get; set; } 
		public string? LevelTwelveClassFeature { get; set; } = null;
		public string? LevelThirteenClassFeature { get; set; } = "Tongue of Son and Moon";
		public string? LevelFourteenClassFeature { get; set; } = "Diamond Soul";
		public string? LevelFifteenClassFeature { get; set; } = "Timeless Body";
		public string? LevelSixteenClassFeature { get; set; } = null;
		public string? LevelSeventeenClassFeature { get; set; }
		public string? LevelEighteenClassFeature { get; set; } = "Empty Body";
		public string? LevelNineteenClassFeature { get; set; } = null;
		public string? LevelTwentyClassFeature { get; set; } = "Perfect Self";
	}
}
