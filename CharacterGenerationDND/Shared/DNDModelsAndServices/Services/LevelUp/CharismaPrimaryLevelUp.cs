using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class CharismaPrimaryLevelUp : ICharismaPrimaryLevelUp
    {
        public Character LevelUpCharisma(Character character)
        {
            if (character.Charisma < 18)
            {
                character.Charisma += 2;
            }
            else if (character.Charisma >= 18 && character.Charisma < 20)
            {
                if (character.FeyTouchedFeat == false)
                {
                    character.FeyTouchedFeat = true;
                    character.Charisma += 1;
                }
                else
                {
                    character.TelekineticFeat = true;
                    character.Charisma += 1;
                }
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Sorcerer && !character.MetaMagicAdeptFeat1 || !character.MetaMagicAdeptFeat2)
            {
                if (!character.MetaMagicAdeptFeat1)
                {
                    character.MetaMagicAdeptFeat1 = true;
                }
                else if (!character.MetaMagicAdeptFeat2)
                {
                    character.MetaMagicAdeptFeat2 = true;
                }
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Warlock && !character.EldritchAdeptFeat1 || !character.EldritchAdeptFeat2)
            {
                if (!character.EldritchAdeptFeat1)
                {
                    character.EldritchAdeptFeat1 = true;
                }
                else if (!character.MetaMagicAdeptFeat2)
                {
                    character.EldritchAdeptFeat2 = true;
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
            else if (character.Wisdom < 19)
            {
                character.Wisdom += 2;
            }
            else if (character.Wisdom == 19)
            {
                character.Wisdom += 1;
                character.Intelligence += 1;
            }
            else
            {
                character.Intelligence += 2;
            }
            return character;
        }
    }
}
