using Estates.Interfaces;

namespace Estates.Data
{
    public class RentOffer : Offer, IRentOffer
    {
        public decimal PricePerMonth { get; set; }

        public RentOffer(OfferType type) : base(type)
        {
        }

        public override string ToString()
        {
            return string.Format(
                "Rent: Estate = {0}, Location = {1}, Price = {2}",
                this.Estate.Name,
                this.Estate.Location,
                this.PricePerMonth);
        }
    }
}
