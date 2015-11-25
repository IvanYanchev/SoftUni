using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    public class AdvanceCinemaEngine : CinemaEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "venue":
                    this.ExecuteInsertVenueCommand(commandWords);
                    break;
                case "performance":
                    this.ExecuteInsertPerformanceCommand(commandWords);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteSellTicketCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            var type = (TicketType)Enum.Parse(typeof(TicketType), commandWords[2], true);
            this.Output.Append(performance.SellTicket(type));
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            //<name>: <tickets_sold> ticket(s), total: $<total_price>
            //Venue: <venue_name> (<venue_location>)
            //Start time: <start_time>

            var performance = this.GetPerformance(commandWords[1]);

            var soldTickets = performance.Tickets.Where(t => t.Status == TicketStatus.Sold);

            decimal total = 0;
            foreach (ITicket ticket in soldTickets)
            {
                total += ticket.Price;
            }

            this.Output.AppendFormat("{0}: {1} ticket(s), total: ${2:F2}", performance.Name, soldTickets.Count(), total).AppendLine();
            this.Output.AppendFormat("Venue: {0} ({1})", performance.Venue.Name, performance.Venue.Location).AppendLine();
            this.Output.AppendFormat("Start time: {0}", performance.StartTime).AppendLine();
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    var cinema = new Cinema(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(cinema);
                    break;
                case "opera":
                    var opera = new Opera(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var spartsHall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(spartsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concertHall);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[5]);

            switch (commandWords[2])
            {
                case "movie":
                    var movie = new Movie(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(movie);
                    break;
                case "theatre":
                    var theatre = new Тheatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            string phrase = commandWords[1];
            this.Output.AppendFormat("Search for \"{0}\"", phrase).AppendLine();

            this.Output.AppendLine("Performances:");

            var matchingPerformances = this.Performances
                .Where(x => x.Name.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) != -1)
                .Where(x => x.StartTime.CompareTo(DateTime.Parse(commandWords[2] + " " + commandWords[3])) >= 0)
                .OrderBy(x => x.StartTime)
                .ThenByDescending(x => x.BasePrice)
                .ThenBy(x => x.Name);

            if (matchingPerformances.Count() > 0)
            {
                foreach (IPerformance performance in matchingPerformances)
                {
                    this.Output.AppendFormat("-{0}", performance.Name).AppendLine();
                }
            }
            else
            {
                this.Output.AppendLine("no results");
            }

            this.Output.AppendLine("Venues:");

            var matchingVenues = this.Venues
                .Where(x => x.Name.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) != -1)
                .OrderBy(x => x.Name);

            if (matchingVenues.Count() > 0)
            {
                foreach (IVenue venue in matchingVenues)
                {
                    this.Output.AppendFormat("-{0}", venue.Name).AppendLine();
                    var performs = this.Performances
                        .Where(x => x.Venue.Equals(venue))
                        .Where(x => x.StartTime.CompareTo(DateTime.Parse(commandWords[2] + " " + commandWords[3])) >= 0)
                        .OrderBy(x => x.StartTime)
                        .ThenByDescending(x => x.BasePrice)
                        .ThenBy(x => x.Name);

                    foreach (IPerformance performance in performs)
                    {
                        this.Output.AppendFormat("--{0}", performance.Name).AppendLine();
                    }
                }
            }
            else
            {
                this.Output.AppendLine("no results");
            }
        }
    }
}
