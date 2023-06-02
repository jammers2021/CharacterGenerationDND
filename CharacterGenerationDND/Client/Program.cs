using CharacterGenerationDND.Client;
using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.DNDModelsAndServices.Services;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services;

namespace CharacterGenerationDND.Client
{
    public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddScoped<IArmorClassCalculations, ArmorClassCalculations>();
			builder.Services.AddScoped<IModifiers, Modifiers>();
			builder.Services.AddScoped<IHitPointCalculation, HitPointCalculation>();
			builder.Services.AddScoped<ISpeciesSelection, SpeciesSelection>();
			builder.Services.AddScoped<IStatsGenerationMethod, StatsGenerationMethod>();
			builder.Services.AddScoped <ICharacterFactory, CharacterFactory>();
			builder.Services.AddScoped<IArmorClassCalculations, ArmorClassCalculations>();
			builder.Services.AddScoped<IModifiers, Modifiers>();
			builder.Services.AddScoped<IHitPointCalculation, HitPointCalculation>();
			builder.Services.AddScoped<ISpeciesSelection, SpeciesSelection>();
			builder.Services.AddScoped<IFeatLevelUp, FeatLevelUp>();
			builder.Services.AddScoped<IIntelligencePrimaryLevelUp, IntelligencePrimaryLevelUp>();
			builder.Services.AddScoped<IWisdomPrimaryLevelUp, WisdomPrimaryLevelUp>();
			builder.Services.AddScoped<ICharismaPrimaryLevelUp, CharismaPrimaryLevelUp>();
			builder.Services.AddScoped<IDexterityPrimaryLevelUp, DexterityPrimaryLevelUp>();
			builder.Services.AddScoped<IStrengthPrimaryLevelUp, StrengthPrimaryLevelUp>();
			builder.Services.AddScoped<ICharacterLevelUp, CharacterLevelUp>();
			await builder.Build().RunAsync();
		}
	}
}