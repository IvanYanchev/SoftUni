using Estates.Engine;
using Estates.Interfaces;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new MyEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            IEstate newEstate = null;

            switch (type)
            {
                case EstateType.Apartment:
                    newEstate = new Apartment();
                    break;
                case EstateType.Garage:
                    newEstate = new Garage();
                    break;
                case EstateType.House:
                    newEstate = new House();
                    break;
                case EstateType.Office:
                    newEstate = new Office();
                    break;
            }

            return newEstate;
        }

        public static IOffer CreateOffer(OfferType type)
        {
            IOffer newOffer = null;

            switch (type)
            {
                case OfferType.Rent:
                    newOffer = new RentOffer(type);
                    break;
                case OfferType.Sale:
                    newOffer = new SaleOffer(type);
                    break;
                default:
                    break;
            }

            return newOffer;
        }
    }
}
