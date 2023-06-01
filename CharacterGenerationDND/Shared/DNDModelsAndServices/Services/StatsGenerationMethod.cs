using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using static CharacterGenerationDND.Shared.DNDModelsAndServices.Models.StatGeneratedMethod;

namespace CharacterGenerationDND.DNDModelsAndServices.Services
{
    public class StatsGenerationMethod : IStatsGenerationMethod
	{
		public List<int> stats { get; set; }
		public List<int> SelectStats(string statsMethod, List<int>? stats = default)
		{
			if (stats == null)
			{
				stats = new List<int>();
			}
			statsMethod = statsMethod.ToLower();

            switch (statsMethod)
			{
				case "rolled":
					var random = new Random(DateTimeOffset.Now.Millisecond);
					Dice myRoll = new D6();

					for (int i = 0; i < 6; i++)
					{
						var rolls1 = new List<int>();
						for (int x = 0; x < 4; x++)
						{
							rolls1.Add(myRoll.Roll());

						}
						rolls1.Sort();
						rolls1.RemoveAt(0);
						stats.Add(rolls1.Sum());
					}
					stats.Sort();
					break;
				case "manual":
                    stats.Sort();
                    break;
				case "chambers":

					random = new Random(DateTimeOffset.Now.Millisecond);
					myRoll = new D6();
					var myd4Roll = new D4();

					for (int i = 0; i < 6; i++)
					{
						var rolls1 = new List<int>();
						for (int x = 0; x < 4; x++)
						{
							rolls1.Add(myRoll.Roll());

						}
						rolls1.Add(myd4Roll.Roll());
						rolls1.Sort();
						rolls1.RemoveAt(0);
						rolls1.RemoveAt(1);
						stats.Add(rolls1.Sum());
					}
					stats.Sort();

					break;
				case "pointbuy":
					stats = new()
					{
						15,15,13,10,10,8
					};
					break;
				case "standardarray":
				default:
					stats = new()
					{
						15,14,13,12,10,8
					};
					break;

			}
			return stats;
		}

	}
}
