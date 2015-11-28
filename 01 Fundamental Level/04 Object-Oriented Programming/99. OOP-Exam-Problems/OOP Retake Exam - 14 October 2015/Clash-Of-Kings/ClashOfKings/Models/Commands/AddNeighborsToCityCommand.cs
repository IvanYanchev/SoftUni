using System;
using System.Collections.Generic;
using ClashOfKings.Attributes;
using ClashOfKings.Contracts;
using ClashOfKings.Exceptions;

namespace ClashOfKings.Models.Commands
{
    [Command]
    public class AddNeighborsToCityCommand : Command
    {
        public AddNeighborsToCityCommand(IGameEngine engine)
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            ICity city = this.Engine.Continent.GetCityByName(commandParams[0]);

            if (city == null)
            {
                throw new NonExistentCityException("City does not exist");
            }
            else
            {
                for (int i = 1; i < commandParams.Length; i += 2)
                {
                    ICity neighborCity = this.Engine.Continent.GetCityByName(commandParams[i]);

                    int distanceToNeighbor = int.Parse(commandParams[i + 1]);

                    if (neighborCity == null)
                    {
                        throw new NonExistentCityException("Specified neighbor does not exist");
                    }
                    else if (distanceToNeighbor < 0)
                    {
                        throw new ArgumentException("The distance between cities cannot be negative");
                    }
                    else
                    {
                        this.Engine.Continent.CityNeighborsAndDistances[city].Add(neighborCity, distanceToNeighbor);
                        this.Engine.Continent.CityNeighborsAndDistances[neighborCity].Add(city, distanceToNeighbor);
                    }
                }

                this.Engine.Render("All valid neighbor records added for city {0}", city.Name);
            }
        }
    }
}
