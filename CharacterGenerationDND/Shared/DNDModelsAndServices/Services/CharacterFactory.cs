using CharacterGenerationDND.Shared.DNDModelsAndServices.Models;
using CharacterGenerationDND.Shared.DNDModelsAndServices.Models.ClassAndSubclassFeatures.Interfaces;
using static CharacterGenerationDND.DNDModelsAndServices.Models.CharacterClassSelection;

namespace CharacterGenerationDND.DNDModelsAndServices.Models;




public class CharacterFactory : ICharacterFactory
{
    private IArmorClassCalculations _armorClassCalculations;
	private IModifiers _modifiers;
	private IHitPointCalculation _hitPointCalculation;
	private ISpeciesSelection _speciesSelection;
	private ICharacterLevelUp _characterLevelUp;
	public CharacterFactory(ICharacterLevelUp characterLevelUp, IArmorClassCalculations armorClassCalculations, IModifiers modifiers, IHitPointCalculation hitPointCalculation, ISpeciesSelection speciesSelection)
    {
        _armorClassCalculations = armorClassCalculations;
		_modifiers = modifiers;
		_hitPointCalculation = hitPointCalculation;
		_speciesSelection = speciesSelection;
		_characterLevelUp = characterLevelUp;
    }
    public Character CreateCharacter(ClassSelection classState, int level, string? subclass, int classVariant, string? species, List<int> stats)
	{
		//Switch case for class
		//Class features
		//Dictionary for class features

		switch (classState)
		{
			case ClassSelection.Artificer:
				var myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[1],
					Level = level,
					Subclass = "",
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[5],
					Strength = stats[0],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					IntSaveProficiency = true,
					ArcanaProf = true,
					InvestigationProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _hitPointCalculation.CalculateHitPoints(myCharacter);
				myCharacter = _modifiers.CreateIntCaster(myCharacter);
				myCharacter =_modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithScaleMailAndShieldMediumArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				if(myCharacter.Level>=3)
				{
					myCharacter.Subclass = subclass;
				}
				return myCharacter;


			case ClassSelection.Barbarian:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[0],
					Constitution = stats[4],
					Dexterity = stats[3],
					Intelligence = stats[1],
					Strength = stats[5],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					StrSaveProficiency=true,
					AthleticsProf = true,
					IntimidationProf = true,
				};
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassBarbarianUnarmored(myCharacter);
				return myCharacter;

			case ClassSelection.Bard:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[5],
					Constitution = stats[4],
					Dexterity = stats[3],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					ChaSavePoficiency = true,
					DexSaveProficiency = true,
					PerceptionProf = true,
					StealthProf = true,
					PerformanceProf = true,
				};
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if(myCharacter.Species=="Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				if (myCharacter.Level >= 2)
				{
					myCharacter.Initiative += myCharacter.ProficiencyBonus/2;
				}
				return myCharacter;

			case ClassSelection.Cleric:
				myCharacter = new Character
				{

					DndClass = classState,
					Subclass = subclass,
					Charisma = stats[0],
					Constitution = stats[3],
					Dexterity = stats[1],
					Intelligence = stats[2],
					Strength = stats[4],
					Wisdom = stats[5],
					ChaSavePoficiency = true,
					WisSaveProficiency = true,
					InsightProf = true,
					ReligionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
				if (myCharacter.Subclass == "Forge Cleric")
				{
					myCharacter.ArmorClass += 1;
				}
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Druid:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[2],
					Subclass = "",
					Constitution = stats[4],
					Dexterity = stats[1],
					Intelligence = stats[3],
					Strength = stats[0],
					Wisdom = stats[5],
					IntSaveProficiency = true,
					WisSaveProficiency = true,
					InsightProf = true,
					PerceptionProf = true,
				};
				if (myCharacter.Level >= 2)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Fighter:
				if (classVariant != 1)
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Subclass = "",
						Charisma = stats[0],
						Constitution = stats[4],
						Dexterity = stats[3],
						Intelligence = stats[1],
						Strength = stats[5],
						Wisdom = stats[2],
						StrSaveProficiency = true,
						ConSaveProficiency = true,
						AthleticsProf = true,
						PerceptionProf= true,
					};
					if (myCharacter.Level >= 3)
					{
						myCharacter.Subclass = subclass;
					}
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
					myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
					myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
					if (myCharacter.Species == "Warforged")
					{
						myCharacter.ArmorClass += 1;
					}
					return myCharacter;

				}
				else
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Subclass = "",
						Charisma = stats[0],
						Constitution = stats[4],
						Dexterity = stats[5],
						Intelligence = stats[1],
						Strength = stats[3],
						Wisdom = stats[2],
						StrSaveProficiency = true,
						ConSaveProficiency = true,
						AcrobaticsProf = true,
						PerceptionProf = true,
					};
					if (myCharacter.Level >= 3)
					{
						myCharacter.Subclass = subclass;
					}
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
					myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
					myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
					if (myCharacter.Species == "Warforged")
					{
						myCharacter.ArmorClass += 1;
					}
					return myCharacter;
				}
			case ClassSelection.Monk:
				if (subclass.ToLower() == "astralself" || subclass.ToLower()=="astral self")
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Charisma = stats[0],
						Subclass = "",
						Constitution = stats[3],
						Dexterity = stats[4],
						Intelligence = stats[1],
						Strength = stats[2],
						Wisdom = stats[5],
						StrSaveProficiency = true,
						DexSaveProficiency = true,
						StealthProf = true,
						AcrobaticsProf = true,
					};
				}
				else
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Charisma = stats[0],
						Subclass = "",
						Constitution = stats[3],
						Dexterity = stats[5],
						Intelligence = stats[1],
						Strength = stats[2],
						Wisdom = stats[4],
						StrSaveProficiency = true,
						DexSaveProficiency = true,
						StealthProf = true,
						AcrobaticsProf = true,
					};
				}
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassMonkUnarmoredDefense(myCharacter);
				return myCharacter;

			case ClassSelection.Paladin:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[4],
					Constitution = stats[3],
					Dexterity = stats[1],
					Intelligence = stats[0],
					Strength = stats[5],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					ChaSavePoficiency = true,
					ReligionProf = true,
					PersuasionProf = true,
				};
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Ranger:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[2],
					Strength = stats[0],
					Wisdom = stats[4],
					StrSaveProficiency = true,
					DexSaveProficiency = true,
					StealthProf = true,
					PerceptionProf = true,
				};
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter); 
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Rogue:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[2],
					Strength = stats[0],
					Wisdom = stats[4],
					DexSaveProficiency = true,
					IntSaveProficiency = true,
					StealthProf = true,
					PerceptionProf = true,
				};
				if (myCharacter.Level >= 3)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Sorcerer:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = subclass,
					Charisma = stats[5],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					ChaSavePoficiency = true,
					ArcanaProf = true,
					DeceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithNoArmor(myCharacter);
				return myCharacter;

			case ClassSelection.Warlock:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = subclass,
					Charisma = stats[5],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					ChaSavePoficiency = true,
					ArcanaProf = true,
					DeceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Wizard:
				myCharacter = new Character
				{
					DndClass = classState,
					Subclass = "",
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[5],
					Strength = stats[0],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					IntSaveProficiency = true,
					ArcanaProf = true,
					InvestigationProf = true,
				};
				if (myCharacter.Level >= 2)
				{
					myCharacter.Subclass = subclass;
				}
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _characterLevelUp.LevelUpCharacter(myCharacter);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateIntCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithNoArmor(myCharacter);
				return myCharacter;
			default:
				return null;

		}

	}


}
