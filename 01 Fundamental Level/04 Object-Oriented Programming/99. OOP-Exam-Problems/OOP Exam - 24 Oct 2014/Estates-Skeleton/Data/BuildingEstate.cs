using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        public int Rooms { get; set; }
        public bool HasElevator { get; set; }

        public override string ToString()
        {
            return
                string.Format(
                    "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, Rooms: {5}, Elevator: {6}",
                    this.GetType().Name,
                    this.Name,
                    this.Area,
                    this.Location,
                    this.IsFurnished ? "Yes" : "No",
                    this.Rooms,
                    this.HasElevator ? "Yes" : "No");
        }
    }
}
