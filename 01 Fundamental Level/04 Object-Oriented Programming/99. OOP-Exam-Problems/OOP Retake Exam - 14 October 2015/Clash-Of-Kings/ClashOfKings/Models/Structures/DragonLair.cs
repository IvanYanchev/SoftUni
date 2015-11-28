using ClashOfKings.Models.Armies;

namespace ClashOfKings.Models.Structures
{
    public class DragonLair : ArmyStructure
    {
        private const int DragonLairBuildCost = 200000;
        private const int DragonLairCapacity = 3;

        public DragonLair() 
            : base(CityType.Capital, DragonLairBuildCost, DragonLairCapacity, UnitType.AirForce)
        {
        }
    }
}
