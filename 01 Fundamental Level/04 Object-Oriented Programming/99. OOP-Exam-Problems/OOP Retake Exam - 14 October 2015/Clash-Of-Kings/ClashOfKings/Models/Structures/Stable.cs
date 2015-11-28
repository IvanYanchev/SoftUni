using ClashOfKings.Models.Armies;

namespace ClashOfKings.Models.Structures
{
    public class Stable : ArmyStructure
    {
        private const int StableBuildCost = 75000;
        private const int StableCapacity = 2500;

        public Stable() 
            : base(CityType.FortifiedCity, StableBuildCost, StableCapacity, UnitType.Cavalry)
        {
        }
    }
}
