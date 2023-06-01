using CharacterGenerationDND.Shared.DNDModelsAndServices.Models;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces
{
    public interface IStatsGenerationMethod
    {
        List<int> stats { get; set; }

        List<int> SelectStats(string statsMethod, List<int>? stats = null);
    }
}