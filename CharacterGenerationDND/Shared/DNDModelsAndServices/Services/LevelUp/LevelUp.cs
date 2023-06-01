using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class LevelUp : ILevelUp
    {
        IWisdomPrimaryLevelUp _wisdomPrimaryLevelUp;
        IIntelligencePrimaryLevelUp _intelligencePrimaryLevelUp;
        ICharismaPrimaryLevelUp _charismaPrimaryLevelUp;
        IDexterityPrimaryLevelUp _dexterityPrimaryLevelUp;
        public LevelUp(IDexterityPrimaryLevelUp dexterityPrimaryLevelUp, ICharismaPrimaryLevelUp charismaPrimaryLevelUp, IIntelligencePrimaryLevelUp intelligencePrimaryLevelUp, IWisdomPrimaryLevelUp wisdomPrimaryLevelUp)
        {
            _intelligencePrimaryLevelUp = intelligencePrimaryLevelUp;
            _wisdomPrimaryLevelUp = wisdomPrimaryLevelUp;
            _charismaPrimaryLevelUp = charismaPrimaryLevelUp;
            _dexterityPrimaryLevelUp = dexterityPrimaryLevelUp;

        }
        public Character StandardFeat(Character character)
        {
            if (character == null) throw new ArgumentNullException();
            if (character.DndClass == CharacterClassSelection.ClassSelection.Cleric || character.DndClass == CharacterClassSelection.ClassSelection.Druid)
            {
                character = _wisdomPrimaryLevelUp.LevelUpWisdom(character);
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Wizard || character.DndClass == CharacterClassSelection.ClassSelection.Artificer)
            {
                character = _intelligencePrimaryLevelUp.LevelUpIntelligence(character);
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Bard || character.DndClass == CharacterClassSelection.ClassSelection.Warlock || character.DndClass == CharacterClassSelection.ClassSelection.Sorcerer)
            {
                character = _charismaPrimaryLevelUp.LevelUpCharisma(character);
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Monk || character.DndClass == CharacterClassSelection.ClassSelection.Rogue || character.DndClass == CharacterClassSelection.ClassSelection.Ranger || character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity > character.Strength)
            {
                character = _dexterityPrimaryLevelUp.LevelUpDexterity(character);
            }
            return character;
        }
        public Character FighterFeat(Character character)
        {
            if (character == null) throw new ArgumentNullException();
            if (character.DndClass != CharacterClassSelection.ClassSelection.Fighter)
            {
                return character;
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity > character.Strength)
            {
                character = _dexterityPrimaryLevelUp.LevelUpDexterity(character);
            }
            return character;
        }

        public Character RogueFeat(Character character)
        {
            if (character == null) throw new ArgumentNullException();
            if (character.DndClass != CharacterClassSelection.ClassSelection.Rogue)
            {
                return character;
            }
            else if (character.DndClass == CharacterClassSelection.ClassSelection.Rogue)
            {
                character = _dexterityPrimaryLevelUp.LevelUpDexterity(character);
            }
            return character;
        }
    }
}
