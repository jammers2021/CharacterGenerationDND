using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class IntelligencePrimaryLevelUp : IIntelligencePrimaryLevelUp
    {
        public Character LevelUpIntelligence(Character character)
        {
            if (character.Intelligence < 18)
            {
                character.Intelligence += 2;
            }
            else if (character.Intelligence >= 18 && character.Intelligence < 20)
            {
                if (character.FeyTouchedFeat == false)
                {
                    character.FeyTouchedFeat = true;
                    character.Intelligence += 1;
                }
                else
                {
                    character.TelekineticFeat = true;
                    character.Intelligence += 1;
                }
            }
            else if (!character.ConSaveProficiency)
            {
                character.ConSaveProficiency = true;
                character.Constitution += 1;
            }
            else if (!character.WarcasterFeat)
            {
                character.WarcasterFeat = true;
            }
            else if (!character.DexSaveProficiency)
            {
                character.DexSaveProficiency = true;
                character.Dexterity += 1;
            }
            else if (character.Constitution < 20 && character.Dexterity < 20 && character.Constitution % 2 != 0)
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
                character.Wisdom += 2;
            }
            return character;
        }
    }
}
