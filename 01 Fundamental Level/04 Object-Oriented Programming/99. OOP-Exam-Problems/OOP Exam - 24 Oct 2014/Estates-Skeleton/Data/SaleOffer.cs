using Estates.Interfaces;

namespace Estates.Data
{
    public class SaleOffer : Offer, ISaleOffer
    {
        public decimal Price { get; set; }

        public SaleOffer(OfferType type) : base(type)
        {
        }

        public override string ToString()
        {
            return string.Format(
                "Sale: Estate = {0}, Location = {1}, Price = {2}",
                this.Estate.Name,
                this.Estate.Location,
                this.Price);
        }
    }
}
