using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Ranger
{
    public class Ranger : IAllCharacters
    {
		public string Class { get; set; } = "Ranger";
		public string? Subclass { get; set; }
		public string? LevelOneClassFeature { get; set; } = "Favored Enemy or (Favored Foe-Opt), Natural Explorer or (Deft Explorer-Opt.)";
		public string? LevelTwoClassFeature { get; set; } = "Fighting style, (Focus-Opt.)";
		public string? LevelThreeClassFeature { get; set; }
		public string? LevelFourClassFeature { get; set; } ="(Martial Versatility Opt.)";
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack";
		public string? LevelSixClassFeature { get; set; } = "Favored Enemy (Or Favored Foe) Improvement, Natural Expolorer (or Deft Explorer) Improvement ";
		public string? LevelSevenClassFeature { get; set; } 
		public string? LevelEightClassFeature { get; set; } = "Land's Stride (Martial Versatility Opt.)";
		public string? LevelNineClassFeature { get; set; } = null;
		public string? LevelTenClassFeature { get; set; } = "Natural Explorer (Or Deft Explorer) Improvement, Hide in Plain Sight or(Nature's Veil-Opt)";
		public string? LevelElevenClassFeature { get; set; }
		public string? LevelTwelveClassFeature { get; set; } = "Martial Versatility";
		public string? LevelThirteenClassFeature { get; set; } = null;
		public string? LevelFourteenClassFeature { get; set; } = "Favored Enemy (or Favored Foe) Improvement, Vanish";
		public string? LevelFifteenClassFeature { get; set; }
		public string? LevelSixteenClassFeature { get; set; } = "Martial Versatility";
		public string? LevelSeventeenClassFeature { get; set; } = null;
		public string? LevelEighteenClassFeature { get; set; } = "Feral Senses";
		public string? LevelNineteenClassFeature { get; set; } = "Martial Versatility";
		public string? LevelTwentyClassFeature { get; set; } = "Foe Slayer";
	}
}
