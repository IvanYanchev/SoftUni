using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class Offer : IOffer
    {
        public OfferType Type { get; set; }
        public IEstate Estate { get; set; }

        protected Offer(OfferType type)
        {
            this.Type = type;
        }
    }
}
