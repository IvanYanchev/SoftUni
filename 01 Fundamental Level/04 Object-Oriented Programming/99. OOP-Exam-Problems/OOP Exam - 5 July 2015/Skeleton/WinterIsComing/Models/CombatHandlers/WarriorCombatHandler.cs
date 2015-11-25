using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    public class WarriorCombatHandler : CombatHandler
    {
        public WarriorCombatHandler(IUnit unit) : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            return candidateTargets
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name)
                .Take(1);
        }

        public override ISpell GenerateAttack()
        {
            ISpell spell;

            if (this.Unit.HealthPoints <= 80)
            {
                spell = new Cleave(this.Unit.AttackPoints + 2 * this.Unit.HealthPoints);
            }
            else
            {
                spell = new Cleave(this.Unit.AttackPoints);
            }


            if (this.Unit.HealthPoints > 50)
            {
                if (this.Unit.EnergyPoints >= spell.EnergyCost)
                {
                    this.Unit.EnergyPoints -= spell.EnergyCost;
                }
                else
                {
                    throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
                }
            }

            return spell;
        }
    }
}
