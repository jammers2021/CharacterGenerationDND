using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class WisdomPrimaryLevelUp : IWisdomPrimaryLevelUp
    {
        public Character LevelUpWisdom(Character character)
        {
            if (character.Wisdom < 18)
            {
                character.Wisdom += 2;
                return character;
            }
            else if (character.Wisdom >= 18 && character.Wisdom < 20)
            {
                if (character.FeyTouchedFeat == false)
                {
                    character.FeyTouchedFeat = true;
                    character.Wisdom += 1;
                }
                else
                {
                    character.TelekineticFeat = true;
                    character.Wisdom += 1;
                }
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Cleric && character.Strength <= 18)
            {
                character.Strength += 2;
                return character;
            }
            else if (!character.WarcasterFeat)
            {
                character.WarcasterFeat = true;
            }
            else if (!character.ConSaveProficiency)
            {
                character.ConSaveProficiency = true;
                character.Constitution += 1;
                return character;
            }
            else if (!character.DexSaveProficiency)
            {
                character.DexSaveProficiency = true;
                character.Dexterity += 1;
                return character;
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Druid)
            {
                if (character.Constitution < 20 && character.Dexterity < 20 && character.Constitution % 2 != 0)
                {
                    character.Constitution += 1;
                    character.Dexterity += 1;
                }
                else if (character.Constitution < 20 && character.Constitution % 2 == 1)
                {
                    character.Constitution += 2;
                }
                else if (character.Dexterity < 20)
                {
                    character.Dexterity += 2;
                }
                else
                {
                    character.Intelligence += 2;
                }
            }
            else
            {
                if (character.Constitution < 20 && character.Strength < 20 && character.Strength % 2 != 0)
                {
                    character.Constitution += 1;
                    character.Strength += 1;
                }
                else if (character.Strength < 20 && character.Constitution % 2 == 1)
                {
                    character.Strength += 2;
                }
                else if (character.Constitution < 20)
                {
                    character.Constitution += 2;
                }
                else
                {
                    character.Intelligence += 2;
                }
            }
            return character;
        }

    }
}
