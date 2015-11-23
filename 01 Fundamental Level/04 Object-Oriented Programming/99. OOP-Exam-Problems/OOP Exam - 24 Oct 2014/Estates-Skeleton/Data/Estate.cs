using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class Estate : IEstate
    {
        public string Name { get; set; }
        public EstateType Type { get; set; }
        public double Area { get; set; }
        public string Location { get; set; }
        public bool IsFurnished { get; set; }
    }
}
