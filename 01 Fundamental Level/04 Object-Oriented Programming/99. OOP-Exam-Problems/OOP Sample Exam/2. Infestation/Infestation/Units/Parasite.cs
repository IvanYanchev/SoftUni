using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.Units
{
    public class Parasite : Unit
    {
        public Parasite(string id)
            : base(id, UnitClassification.Biological, 1, 1, 1)
        {
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (this.Id != unit.Id)
            {
                if (this.UnitClassification == InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification))
                {
                    return true;
                }
            }
            return false;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with the least health and attacks it
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, int.MaxValue, 0, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
