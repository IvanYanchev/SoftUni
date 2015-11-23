using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Supplements;
using Infestation.Units;

namespace Infestation
{
    public class MyHoldingPen : HoldingPen
    {

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Dog":
                    var dog = new Dog(commandWords[2]);
                    this.InsertUnit(dog);
                    break;
                case "Human":
                    var human = new Human(commandWords[2]);
                    this.InsertUnit(human);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    break;
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            Unit targetUnit = this.GetUnit(interaction.TargetUnit);

            switch (interaction.InteractionType)
            {
                case InteractionType.Attack:
                    targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                    break;
                case InteractionType.Infest:
                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            ISupplement supplement = null;
            Unit targetUnit = this.GetUnit(commandWords[2]);

            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    supplement = new PowerCatalyst();
                    break;
                case "HealthCatalyst":
                    supplement = new HealthCatalyst();
                    break;
                case "AggressionCatalyst":
                    supplement = new AggressionCatalyst();
                    break;
                case "Weapon":
                    supplement = new Weapon();
                    break;
                default:
                    break;
            }

            targetUnit.AddSupplement(supplement);
        }
    }
}
