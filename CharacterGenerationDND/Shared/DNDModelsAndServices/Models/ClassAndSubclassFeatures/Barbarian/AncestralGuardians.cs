using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian
{
    public class AncestralGuardians:Barbarian,IAllCharacters
	{
		public string Subclass = "Path of Ancestral Guardians";
		public string? LevelThreeClassFeature = "Ancestral Protector, (Primal Knowledge-Opt.)";
		public string? LevelSixClassFeature = "Spirit Shield";
		public string? LevelTenClassFeature = "Consult the Spirits";
		public string? LevelFourteenClassFeature = "Vengeful Ancestors";
	}
}
