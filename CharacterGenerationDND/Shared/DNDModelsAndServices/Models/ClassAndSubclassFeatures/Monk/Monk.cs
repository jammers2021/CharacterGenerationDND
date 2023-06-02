using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk
{
	public class Monk: AllCharacters
	{
		public Monk() : base() 
		{
			Class = "Monk";
			LevelOneClassFeature = "Unarmored Defense, Martial Arts";
			LevelTwoClassFeature = "Ki, Unarmored Movement, (Dedicated Weapon-Opt.)";
			LevelFourClassFeature = "Slow Fall, (Quickened Healing-Opt.)";
			LevelFiveClassFeature = "Extra Attack, Stunning Strike, (Focused Aim-Opt.)";
			LevelSevenClassFeature = "Evasion, Stillness of Mind";
			LevelNineClassFeature = "Unarmored Movement Improvement";
			LevelTenClassFeature = "Purity of Body";
			LevelThirteenClassFeature = "Tongue of Son and Moon";
			LevelFourteenClassFeature = "Diamond Soul";
			LevelFifteenClassFeature = "Timeless Body";
			LevelEighteenClassFeature = "Empty Body";
			LevelTwentyClassFeature = "Perfect Self";
		}
	}
}
