using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Ranger
{
    public class Ranger : AllCharacters
    {
		public Ranger() : base()
		{
			Class = "Ranger";
			LevelOneClassFeature = "Favored Enemy or (Favored Foe-Opt), Natural Explorer or (Deft Explorer-Opt.)";
			LevelTwoClassFeature = "Fighting style, (Focus-Opt.)";
			LevelFourClassFeature = "(Martial Versatility Opt.)";
			LevelFiveClassFeature = "Extra Attack";
			LevelSixClassFeature = "Favored Enemy (Or Favored Foe) Improvement, Natural Expolorer (or Deft Explorer) Improvement ";
			LevelEightClassFeature = "Land's Stride (Martial Versatility Opt.)";
			LevelTenClassFeature = "Natural Explorer (Or Deft Explorer) Improvement, Hide in Plain Sight or(Nature's Veil-Opt)";
			LevelTwelveClassFeature = "Martial Versatility";
			LevelFourteenClassFeature = "Favored Enemy (or Favored Foe) Improvement, Vanish";
			LevelSixteenClassFeature = "Martial Versatility";
			LevelEighteenClassFeature = "Feral Senses";
			LevelNineteenClassFeature = "Martial Versatility";
			LevelTwentyClassFeature = "Foe Slayer";
		}
	}
}
