using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class StrengthPrimaryLevelUp : IStrengthPrimaryLevelUp
	{
		public Character LevelUpStrength(Character character)
		{
			if (character.Strength < 18)
			{
				character.Strength += 2;
			}
			else if (character.Strength >= 18 && character.Strength < 20)
			{
				if (!character.SlasherFeat)
				{
					character.SlasherFeat = true;
					character.Strength += 1;
				}
				else if (!character.CrusherFeat)
				{
					character.CrusherFeat = true;
					character.Strength += 1;
				}
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Paladin && character.Charisma < 20)
			{
				if (character.Charisma < 18)
				{
					character.Charisma += 2;
				}
				else if (!character.FeyTouchedFeat)
				{
					character.FeyTouchedFeat = true;
					character.Charisma += 1;
				}
				else if (!character.TelekineticFeat)
				{
					character.TelekineticFeat = true;
					character.Charisma += 1;
				}
				else
				{
					character.Charisma += 1;
					character.Constitution += 1;
				}
			}
			else if (!character.GreatWeaponMaster)
			{
				character.GreatWeaponMaster = true;
			}
			else if (!character.CrusherFeat && character.Constitution < 20)
			{
				if (!character.CrusherFeat)
				{
					character.CrusherFeat = true;
					character.Constitution += 1;
				}
			}
			else if (character.Constitution < 18)
			{
				character.Constitution += 2;
			}
			else if (character.Constitution >= 18 && character.Constitution < 20)
			{
				if (!character.ConSaveProficiency)
				{
					character.ConSaveProficiency = true;
					character.Constitution += 1;
				}
				else if (!character.ChefFeat)
				{
					character.ChefFeat = true;
					character.Constitution += 1;
				}
				else if (character.Dexterity < 20)
				{
					character.Dexterity += 1;
					character.Constitution += 1;
				}
				else if (character.Wisdom < 20)
				{
					character.Constitution += 1;
					character.Wisdom += 1;
				}
				else
				{
					character.Constitution += 1;
					character.Intelligence += 1;
				}
			}
			else if (character.Dexterity <= 18)
			{
				character.Dexterity += 2;
			}
			else if (character.Dexterity == 19)
			{
				character.Dexterity += 1;
				character.PiercerFeat = true;
			}
			else if (!character.AlertFeat)
			{
				character.AlertFeat = true;
			}
			else if (!character.PoleArmMaster)
			{
				character.PoleArmMaster = true;
			}
			else if (!character.MobileFeat)
			{
				character.MobileFeat = true;
			}
			else if (character.Wisdom <= 18)
			{
				character.Wisdom += 2;
			}
			else if (character.Wisdom == 19)
			{
				character.Wisdom += 1;
				character.ObservantFeat = true;
			}
			else if (!character.CrossbowExpertFeat)
			{
				character.CrossbowExpertFeat = true;
			}
			else if (!character.SharpshooterFeat)
			{
				character.SharpshooterFeat = true;
			}
			else if (character.Charisma <= 18)
			{
				character.Charisma += 2;
			}
			else if (character.Charisma == 19)
			{
				character.Actor = true;
				character.Charisma += 1;

			}
			else if (character.Intelligence <= 18)
			{
				character.Intelligence += 2;
			}
			else if (character.Intelligence == 19)
			{
				if (!character.ObservantFeat)
				{
					character.ObservantFeat = true;
					character.Intelligence += 1;
				}
				else
				{
					character.KeenMind = true;
					character.Intelligence += 1;
				}
			}
			return character;
		}
	}
}
