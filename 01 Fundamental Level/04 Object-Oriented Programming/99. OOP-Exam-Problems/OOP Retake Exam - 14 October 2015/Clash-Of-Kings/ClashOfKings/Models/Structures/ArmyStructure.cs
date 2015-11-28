using ClashOfKings.Contracts;
using ClashOfKings.Models.Armies;

namespace ClashOfKings.Models.Structures
{
    public class ArmyStructure : IArmyStructure
    {
        public ArmyStructure(CityType requiredCityType, decimal buildCost, int capacity, UnitType unitType)
        {
            this.RequiredCityType = requiredCityType;
            this.BuildCost = buildCost;
            this.Capacity = capacity;
            this.UnitType = unitType;
        }

        public CityType RequiredCityType { get; }
        public decimal BuildCost { get; }
        public int Capacity { get; }
        public UnitType UnitType { get; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
