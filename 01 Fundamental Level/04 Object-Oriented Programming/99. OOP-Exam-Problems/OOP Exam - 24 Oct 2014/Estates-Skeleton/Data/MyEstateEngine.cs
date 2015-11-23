using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Engine;
using Estates.Interfaces;

namespace Estates.Data
{
    class MyEstateEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "create":
                    return ExecuteCreateCommand(cmdArgs);
                case "status":
                    return ExecuteStatusCommand();
                case "find-sales-by-location":
                    return this.ExecuteFindSalesByLocationCommand(cmdArgs[0]);
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPriceCommand(cmdArgs[0], cmdArgs[1]);
                default:
                    throw new NotImplementedException("Unknown command: " + cmdName);
            }
        }

        private string ExecuteFindRentsByPriceCommand(string min, string max)
        {
            decimal minPrice = decimal.Parse(min);
            decimal maxPrice = decimal.Parse(max);

            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Select(o => (IRentOffer)o)
                .Where(o => o.PricePerMonth >= minPrice && o.PricePerMonth <= maxPrice)
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);

            return this.FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Where(o => o.Estate.Location == location)
                .OrderBy(o => o.Estate.Name);

            return this.FormatQueryResults(offers);
        }

        private string ExecuteFindSalesByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Type == OfferType.Sale)
                .Where(o => o.Estate.Location == location)
                .OrderBy(o => o.Estate.Name);

            return this.FormatQueryResults(offers);
        }
    }
}
