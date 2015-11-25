using System;
using System.Collections.Generic;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.CombatHandlers
{
    public abstract class CombatHandler : ICombatHandler
    {
        public IUnit Unit { get; set; }

        protected CombatHandler(IUnit unit)
        {
            Unit = unit;
        }

        public abstract IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets);

        public abstract ISpell GenerateAttack();
    }
}
