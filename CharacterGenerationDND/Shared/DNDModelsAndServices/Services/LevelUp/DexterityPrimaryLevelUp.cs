using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class DexterityPrimaryLevelUp : IDexterityPrimaryLevelUp
    {
        public Character LevelUpDexterity(Character character)
        {
            if (character == null) throw new ArgumentNullException();
            if (character.Subclass != null && (character.Subclass.ToLower() == "astral self" || character.Subclass.ToLower() == "astralself" && character.Wisdom < 20))
            {
                if (character.Wisdom <= 18)
                {
                    character.Wisdom += 2;
                }
                else if (character.Dexterity < 20)
                {
                    character.Wisdom += 1;
                    character.Dexterity += 1;
                }
                else
                {
                    character.Wisdom += 1;
                    character.Constitution += 1;
                }
            }

            if (character.Dexterity < 18 || character.DndClass == CharacterClassSelection.ClassSelection.Monk && character.Dexterity == 18)
            {
                character.Dexterity += 2;
            }
            else if (character.Dexterity >= 18 && character.Dexterity < 20)
            {
                if (character.DndClass == CharacterClassSelection.ClassSelection.Monk && character.Constitution < 20 && !character.CrusherFeat)
                {
                    character.CrusherFeat = true;
                    character.Constitution += 1;
                }
                else if (character.PiercerFeat == false)
                {
                    character.PiercerFeat = true;
                    character.Dexterity += 1;
                }
                else if (character.Dexterity == 18)
                {
                    character.Dexterity += 2;
                }
                else if (character.Wisdom < 20)
                {
                    character.Wisdom += 1;
                    character.Dexterity += 1;
                }
                else
                {
                    character.Constitution += 1;
                    character.Dexterity += 1;
                }
            }
            else if (character.DndClass != CharacterClassSelection.ClassSelection.Monk && !character.CrossbowExpertFeat)
            {
                character.CrossbowExpertFeat = true;
            }
            else if (character.DndClass != CharacterClassSelection.ClassSelection.Monk && !character.SharpshooterFeat)
            {
                character.SharpshooterFeat = true;
            }
            else if ((character.Subclass.ToLower() == "eldtritch knight" || character.Subclass.ToLower() == "eldritchknight" || character.Subclass.ToLower() == "arcane trickster" || character.Subclass.ToLower() == "arcanetrickster") && character.Intelligence < 20)
            {
                if (character.Intelligence < 18)
                {
                    character.Intelligence += 2;
                }
                else if (!character.FeyTouchedFeat)
                {
                    character.Intelligence += 1;
                    character.FeyTouchedFeat = true;
                }
                else if (character.FeyTouchedFeat && !character.TelekineticFeat)
                {
                    character.Intelligence += 1;
                    character.TelekineticFeat = true;
                }
                else if (character.Wisdom < 20)
                {
                    character.Intelligence += 1;
                    character.Wisdom += 1;
                }
                else if (character.Constitution < 20)
                {
                    character.Intelligence += 1;
                    character.Constitution += 1;
                }
                else
                {
                    character.Intelligence += 1;
                    character.Charisma += 1;
                }

            }
            else if (character.DndClass != CharacterClassSelection.ClassSelection.Monk && !character.WisSaveProficiency && character.Wisdom < 20)
            {
                character.Wisdom += 1;
                character.WisSaveProficiency = true;
            }
            else if (character.DndClass != CharacterClassSelection.ClassSelection.Monk && !character.ConSaveProficiency && character.Constitution < 20)
            {
                character.Constitution += 1;
                character.ConSaveProficiency = true;
            }
            else if (character.Wisdom <= 18)
            {
                character.Wisdom += 2;
            }
            else if (character.Wisdom == 19)
            {
                character.Wisdom += 1;
                if (character.Constitution < 20)
                {
                    character.Constitution += 1;
                }
            }
            else if (!character.AlertFeat)
            {
                character.AlertFeat = true;
            }
            else if (!character.MobileFeat)
            {
                character.MobileFeat = true;
            }
            else if (character.Constitution <= 18)
            {
                character.Constitution += 2;
            }
            else if (character.Constitution == 19)
            {
                character.Constitution += 1;
                if (character.Intelligence < 20)
                {
                    character.Intelligence += 1;
                }
                else if (character.Charisma < 20)
                {
                    character.Charisma += 1;
                }
                else
                {
                    character.Strength += 1;
                }
            }
            else if (character.Intelligence <= 18)
            {
                character.Intelligence += 2;
            }
            else if (character.Intelligence == 19 && character.Strength < 20)
            {
                character.Intelligence += 1;
                character.Strength += 1;
            }
            else if (character.Strength <= 18)
            {
                character.Strength += 2;
            }
            else
            {
                character.ChefFeat = true;
            }
            return character;
        }

    }
}
