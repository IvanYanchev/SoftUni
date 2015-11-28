using ClashOfKings.Models.Armies;

namespace ClashOfKings.Models.Structures
{
    public class Barracks : ArmyStructure
    {
        private const int BarracksBuildCost = 15000;
        private const int BarracksCapacity = 5000;

        public Barracks()
            : base(CityType.Keep, BarracksBuildCost, BarracksCapacity, UnitType.Infantry)
        {
        }
    }
}
