using CharacterGenerationDND.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Artificer;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Barbarian;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Bard;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Cleric;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Druid;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Fighter;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Monk;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Paladin;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Ranger;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Rogue;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Sorcerer;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Warlock;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Wizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CharacterGenerationDND.Shared.DNDModelsAndServices.Services.LevelUp
{
    public class CharacterLevelUp : ICharacterLevelUp
    {
        private IFeatLevelUp _featLevelUp;
        public CharacterLevelUp(IFeatLevelUp featLevelUp)
        {
            _featLevelUp = featLevelUp;
        }
        public Character LevelUpCharacter(Character character)
        {
            if (character == null) throw new ArgumentNullException();
            if (character.Level == 0)
            {
                character.Level = 1;
            }
            AllCharacters dndCharacter = new();
            var subclass = character.Subclass;
            switch (subclass.ToLower())
            {
                case "alchemist":
                    Alchemist alchemist = new();
                    dndCharacter = alchemist;
                    break;
                case "armorer":
                    Armorer armorer = new();
                    dndCharacter = armorer;
                    break;
                case "ancestralguardians":
                case "ancestral guardians":
                    AncestralGuardians ancestralGuardians = new();
                    dndCharacter = ancestralGuardians;
                    break;
                case "totem":
                    Totem totem = new();
                    dndCharacter = totem;
                    break;
                case "eloquence":
                case "college of eloquence":
                case "collegeofeloquence":
                    Eloquence eloquence = new();
                    dndCharacter = eloquence;
                    break;
                case "lore":
                case "college of lore":
                case "collegeoflore":
                    Lore lore = new();
                    dndCharacter = lore;
                    break;
                case "forge":
                    Forge forge = new();
                    dndCharacter = forge;
                    break;
                case "life":
                    Life life = new();
                    dndCharacter = life;
                    break;
                case "moon":
                case "circle of moon":
                case "circleofmoon":
                    Moon moon = new();
                    dndCharacter = moon;
                    break;
                case "stars":
                case "circle of stars":
                case "circleofstars":
                    Stars stars = new();
                    dndCharacter = stars;
                    break;
                case "echoknight":
                case "echo knight":
                    EchoKnight echoKnight = new();
                    dndCharacter = echoKnight;
                    break;
                case "eldritchknight":
                case "eldritch knight":
                    EldritchKnight eldritchKnight = new();
                    dndCharacter = eldritchKnight;
                    break;
                case "astralself":
                case "astral self":
                case "way of astral self":
                case "wayofastralself":
                    AstralSelf astralSelf = new();
                    dndCharacter = astralSelf;
                    break;
                case "mercy":
                case "way of mercy":
                case "wayofmercy":
                    Mercy mercy = new();
                    dndCharacter = mercy;
                    break;
                case "crown":
                case "oath of crown":
                case "oath of the crown":
                case "oathofcrown":
                case "oathofthecrown":
                    Crown crown = new();
                    dndCharacter = crown;
                    break;
                case "vengeance":
                case "oath of vengeance":
                case "oathofvengeance":
                    Vengeance vengeance = new();
                    dndCharacter = vengeance;
                    break;
                case "drakewarden":
                    Drakewarden drakewarden = new();
                    dndCharacter = drakewarden;
                    break;
                case "gloomstalker":
                    Gloomstalker gloomstalker = new();
                    dndCharacter = gloomstalker;
                    break;
                case "arcanetrickster":
                case "arcane trickster":
                    ArcaneTrickster arcaneTrickster = new();
                    dndCharacter = arcaneTrickster;
                    break;
                case "soulknife":
                case "soul knife":
                    Soulknife soulknife = new();
                    dndCharacter = soulknife;
                    break;
                case "draconicbloodline":
                case "draconic bloodine":
                case "draconic":
                    DraconicBloodline draconicBloodline = new();
                    dndCharacter = draconicBloodline;
                    break;
                case "shadowmagic":
                case "shadow magic":
                    ShadowMagic shadowMagic = new();
                    dndCharacter = shadowMagic;
                    break;
                case "genie":
                case "pact of the genie":
                case "pactofthegenie":
                    Genie genie = new();
                    dndCharacter = genie;
                    break;
                case "hexblade":
                    Hexblade hexblade = new();
                    dndCharacter = hexblade;
                    break;
                case "bladesinging":
                case "bladesinger":
                    Bladesinging bladesinging = new();
                    dndCharacter = bladesinging;
                    break;
                case "scribes":
                case "order of scribes":
                case "orderofscribes":
                    Scribes scribes = new();
                    dndCharacter = scribes;
                    break;
                default:
                    break;
            }
            

			character.ClassFeatures = new();
            if (character.Level >= 1)
            {
                if (dndCharacter.LevelOneClassFeature != null)
                {
					character.ClassFeatures.Add(dndCharacter.LevelOneClassFeature.ToString());
				}
            }
            if (character.Level >= 2)
            {
                if (dndCharacter.LevelTwoClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelTwoClassFeature.ToString());
                }
            }
            if (character.Level >= 3)
            {
                if (dndCharacter.LevelThreeClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelThreeClassFeature.ToString());
                }
            }
            if (character.Level >= 4)
            {
                if (dndCharacter.LevelFourClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelFourClassFeature.ToString());
                }
                _featLevelUp.StandardFeat(character);
            }
            if (character.Level >= 5)
            {
                if (dndCharacter.LevelFiveClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelFiveClassFeature.ToString());
                }
            }
            if (character.Level >= 6)
            {
                if (dndCharacter.LevelSixClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelSixClassFeature.ToString());
                }
                _featLevelUp.FighterFeat(character);
            }
            if (character.Level >= 7)
            {
                if (dndCharacter.LevelSevenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelSevenClassFeature.ToString());
                }
            }
            if (character.Level >= 8)
            {
                if (dndCharacter.LevelEightClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelEightClassFeature.ToString());
                }
				_featLevelUp.StandardFeat(character);
			}
            if (character.Level >= 9)
            {
                if (dndCharacter.LevelNineClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelNineClassFeature.ToString());
                }
            }
            if (character.Level >= 10)
            {
                if (dndCharacter.LevelTenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelTenClassFeature.ToString());
                }
                _featLevelUp.RogueFeat(character);
            }
            if (character.Level >= 11)
            {
                if (dndCharacter.LevelElevenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelElevenClassFeature.ToString());
                }
            }
            if (character.Level >= 12)
            {
                if (dndCharacter.LevelTwelveClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelTwelveClassFeature.ToString());
                }
                _featLevelUp.StandardFeat(character);
            }
            if (character.Level >= 13)
            {
                if (dndCharacter.LevelThirteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelThirteenClassFeature.ToString());
                }
            }
            if (character.Level >= 14)
            {
                if (dndCharacter.LevelFourteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelFourteenClassFeature.ToString());
                }
                _featLevelUp.FighterFeat(character);
            }
            if (character.Level >= 15)
            {
                if (dndCharacter.LevelFifteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelFifteenClassFeature.ToString());
                }
            }
            if (character.Level >= 16)
            {
                if (dndCharacter.LevelSixteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelSixteenClassFeature.ToString());
                }
                _featLevelUp.StandardFeat(character);
            }
            if (character.Level >= 17)
            {
                if (dndCharacter.LevelSeventeenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelSeventeenClassFeature.ToString());
                }
            }
            if (character.Level >= 18)
            {
                if (dndCharacter.LevelEighteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelEighteenClassFeature.ToString());
                }
            }
            if (character.Level >= 19)
            {
                if (dndCharacter.LevelNineteenClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelNineteenClassFeature.ToString());
                }
                _featLevelUp.StandardFeat(character);
            }
            if (character.Level == 20)
            {
                if (dndCharacter.LevelTwentyClassFeature != null)
                {
                    character.ClassFeatures.Add(dndCharacter.LevelTwentyClassFeature.ToString());
                }
            }
            return character;
        }
    }
}
