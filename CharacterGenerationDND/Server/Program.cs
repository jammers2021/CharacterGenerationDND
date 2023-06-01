using CharacterGenerationDND.DNDModelsAndServices.Services;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp;
using Microsoft.AspNetCore.ResponseCompression;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services;

namespace CharacterGenerationDND
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddScoped<IArmorClassCalculations, ArmorClassCalculations>();
			builder.Services.AddScoped<IModifiers, Modifiers>();
			builder.Services.AddScoped<IHitPointCalculation, HitPointCalculation>();
			builder.Services.AddScoped<ISpeciesSelection, SpeciesSelection>();
			builder.Services.AddScoped<ILevelUp, LevelUp>();
			builder.Services.AddScoped<IIntelligencePrimaryLevelUp, IntelligencePrimaryLevelUp>();
			builder.Services.AddScoped<IWisdomPrimaryLevelUp, WisdomPrimaryLevelUp>();
			builder.Services.AddScoped<ICharismaPrimaryLevelUp, CharismaPrimaryLevelUp>();
			builder.Services.AddScoped<IDexterityPrimaryLevelUp, IDexterityPrimaryLevelUp>();
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();


			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}