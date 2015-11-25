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
    public class IceGiantCombatHandler : CombatHandler
    {
        public IceGiantCombatHandler(IUnit unit) : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (this.Unit.HealthPoints <= 150)
            {
                return candidateTargets.Take(1);
            }

            return candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            ISpell spell = new Stomp(this.Unit.AttackPoints);

            if (this.Unit.EnergyPoints >= spell.EnergyCost)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
                this.Unit.AttackPoints += 5;
            }
            else
            {
                throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
            }

            return spell;
        }
    }
}
