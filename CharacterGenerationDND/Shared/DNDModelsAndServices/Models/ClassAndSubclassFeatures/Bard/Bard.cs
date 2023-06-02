using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard
{
    public class Bard : AllCharacters
	{
		public Bard() : base() 
		{
			Class = "Bard";
			LevelOneClassFeature = "Bardic Inspiration(d6)";
			LevelTwoClassFeature = "Jack of All Trades, Song of Rest(d6), (Magical Inspiration-Opt)";
			LevelFiveClassFeature = "Font of Inspiration, Bardic Inspiration(d8)";
			LevelNineClassFeature = "Song of Rest(d8)";
			LevelTenClassFeature = "Bardic Inspiration(d10), Expertise, Magical Secrets";
			LevelThirteenClassFeature = "Song of Rest (d10)";
			LevelFifteenClassFeature = "Bardic Inspiration (d12)";
			LevelSeventeenClassFeature = "Song of Rest (d12)";
			LevelEighteenClassFeature = "Magical Secrets";
			LevelTwentyClassFeature = "Superior Inspiration";
		}
		
		
	}
}
