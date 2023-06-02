using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter
{
	public class Fighter: AllCharacters
	{
		public string Class { get; set; } = "Fighter";
		public string? LevelOneClassFeature { get; set; } = "Fighting Style, Second Wind";
		public string? LevelTwoClassFeature { get; set; } = "Action Surge";
		public string? LevelFiveClassFeature { get; set; } = "Extra Attack";
		public string? LevelEightClassFeature { get; set; } = "Wild Shape Improvement";
		public string? LevelNineClassFeature { get; set; } = "Indomitable";
		public string? LevelElevenClassFeature { get; set; } = "Extra Attack(X2)";
		public string? LevelThirteenClassFeature { get; set; } = "Indomitable(X2)";
		public string? LevelSeventeenClassFeature { get; set; } = "Action Surge(X2), Indomitable(X3)";
		public string? LevelTwentyClassFeature { get; set; } = "Extra Attack(X3)";
	}
}
