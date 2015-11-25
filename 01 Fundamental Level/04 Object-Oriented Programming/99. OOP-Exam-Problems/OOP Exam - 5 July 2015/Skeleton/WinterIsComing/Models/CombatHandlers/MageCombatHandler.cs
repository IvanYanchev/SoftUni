using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;
using WinterIsComing.Models.Units;

namespace WinterIsComing.Models.CombatHandlers
{
    public class MageCombatHandler : CombatHandler
    {
        public MageCombatHandler(IUnit unit) : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            return candidateTargets
                .OrderByDescending(x => x.HealthPoints)
                .ThenBy(x => x.Name)
                .Take(3);
        }

        public override ISpell GenerateAttack()
        {
            ISpell spell;

            if (((Mage)this.Unit).IsAlternateSpell)
            {
                spell = new Blizzard(this.Unit.AttackPoints * 2);
            }
            else
            {
                spell = new FireBreath(this.Unit.AttackPoints);
            }

            if (this.Unit.EnergyPoints >= spell.EnergyCost)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
                ((Mage) this.Unit).IsAlternateSpell = !((Mage) this.Unit).IsAlternateSpell;
            }
            else
            {
                throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
            }

            return spell;
        }
    }
}
