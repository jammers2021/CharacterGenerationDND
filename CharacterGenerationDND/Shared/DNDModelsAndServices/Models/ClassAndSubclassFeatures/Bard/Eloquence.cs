using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
    public class Eloquence: Bard, IAllCharacters
	{
		public string? Subclass { get; set; } = "College of Eloquence";
		public string? LevelThreeClassFeature { get; set; } = "Expertise, Silver Tongue-Persuasion";
		public string? LevelSixClassFeature { get; set; } = "CounterCharm, Unfailing Inspiration, Universal Speech";
		public string? LevelFourteenClassFeature { get; set; } = "Magical Secrets, Infectious Inspiration";
	}
}
