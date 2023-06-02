using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian
{
	public class AncestralGuardians : Barbarian
	{
		public AncestralGuardians() : base()
		{
			Subclass = "Path of Ancestral Guardians";
			LevelThreeClassFeature = "Ancestral Protector, (Primal Knowledge-Opt.)";
			LevelSixClassFeature = "Spirit Shield";
			LevelTenClassFeature = "Consult the Spirits";
			LevelFourteenClassFeature = "Vengeful Ancestors";
		}
	}
}
