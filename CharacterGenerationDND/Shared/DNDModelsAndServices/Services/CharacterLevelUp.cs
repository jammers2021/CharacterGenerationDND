using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services
{
	public class CharacterLevelUp
	{
		public Character SelectSubclass (Character character)
		{
			if (character != null)
			{

				CharacterClassSelection.ClassSelection artificer = CharacterClassSelection.ClassSelection.Artificer;
				CharacterClassSelection.ClassSelection barbarian = CharacterClassSelection.ClassSelection.Barbarian;
				CharacterClassSelection.ClassSelection bard = CharacterClassSelection.ClassSelection.Bard;
				CharacterClassSelection.ClassSelection cleric = CharacterClassSelection.ClassSelection.Cleric;
				CharacterClassSelection.ClassSelection druid = CharacterClassSelection.ClassSelection.Druid;
				CharacterClassSelection.ClassSelection monk = CharacterClassSelection.ClassSelection.Monk;
				CharacterClassSelection.ClassSelection paladin = CharacterClassSelection.ClassSelection.Paladin;
				CharacterClassSelection.ClassSelection ranger = CharacterClassSelection.ClassSelection.Ranger;
				CharacterClassSelection.ClassSelection rogue = CharacterClassSelection.ClassSelection.Rogue;
				CharacterClassSelection.ClassSelection sorcerer = CharacterClassSelection.ClassSelection.Sorcerer;
				CharacterClassSelection.ClassSelection warlock = CharacterClassSelection.ClassSelection.Warlock;
				CharacterClassSelection.ClassSelection wizard = CharacterClassSelection.ClassSelection.Wizard;

				if (character.DndClass == artificer)
				{
					
				}
				return character;
			}
			return character;
		}
		public Character LevelUpCharacter(Character character) 
		{
			if (character == null) throw new ArgumentNullException();
			if (character.Level == 0)
			{
				character.Level = 1;
			}
			var subclass = character.Subclass;
			IAllCharacters dndCharacter = null;
			switch (subclass.ToLower())
			{
				case "alchemist":
					Alchemist alchemist = new();
					dndCharacter = alchemist;
					break;
				default: 
					break;
			}

			

			if (character.Level >= 1) 
			{
				character.ClassFeatures.Add(dndCharacter.LevelOneClassFeature);
			}
			if(character.Level >= 2)
			{
				character.ClassFeatures.Add(dndCharacter.LevelTwoClassFeature);
			}
			if (character.Level >= 3)
			{
				character.ClassFeatures.Add(dndCharacter.LevelThreeClassFeature);
			}
			if (character.Level >= 4)
			{
				character.ClassFeatures.Add(dndCharacter.LevelFourClassFeature);
			}
			if (character.Level >= 5)
			{
				character.ClassFeatures.Add(dndCharacter.LevelFiveClassFeature);
			}
			if (character.Level >= 6)
			{
				character.ClassFeatures.Add(dndCharacter.LevelSixClassFeature);
			}
			if (character.Level >= 7)
			{
				character.ClassFeatures.Add(dndCharacter.LevelSevenClassFeature);
			}
			if (character.Level >= 8)
			{
				character.ClassFeatures.Add(dndCharacter.LevelEightClassFeature);
			}
			if (character.Level >= 9)
			{
				character.ClassFeatures.Add(dndCharacter.LevelNineClassFeature);
			}
			if (character.Level >= 10)
			{
				character.ClassFeatures.Add(dndCharacter.LevelThreeClassFeature);
			}
			if (character.Level >= 11)
			{
				character.ClassFeatures.Add(dndCharacter.LevelElevenClassFeature);
			}
			if (character.Level >= 12)
			{
				character.ClassFeatures.Add(dndCharacter.LevelTwelveClassFeature);
			}
			if (character.Level >= 13)
			{
				character.ClassFeatures.Add(dndCharacter.LevelThirteenClassFeature);
			}
			if (character.Level >= 14)
			{
				character.ClassFeatures.Add(dndCharacter.LevelFourteenClassFeature);
			}
			if (character.Level >= 15)
			{
				character.ClassFeatures.Add(dndCharacter.LevelFifteenClassFeature);
			}
			if (character.Level >= 16)
			{
				character.ClassFeatures.Add(dndCharacter.LevelSixteenClassFeature);
			}
			if (character.Level >= 17)
			{
				character.ClassFeatures.Add(dndCharacter.LevelSeventeenClassFeature);
			}
			if (character.Level >= 18)
			{
				character.ClassFeatures.Add(dndCharacter.LevelEighteenClassFeature);
			}
			if (character.Level >= 19)
			{
				character.ClassFeatures.Add(dndCharacter.LevelNineteenClassFeature);
			}
			if (character.Level == 20)
			{
				character.ClassFeatures.Add(dndCharacter.LevelTwentyClassFeature);
			}
			return character;
		}
	}
}
