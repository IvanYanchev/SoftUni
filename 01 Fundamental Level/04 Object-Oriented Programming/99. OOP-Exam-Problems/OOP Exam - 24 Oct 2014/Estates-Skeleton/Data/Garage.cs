using Estates.Interfaces;

namespace Estates.Data
{
    public class Garage : Estate, IGarage
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return
                string.Format(
                    "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, Width: {5}, Height: {6}",
                    this.GetType().Name,
                    this.Name,
                    this.Area,
                    this.Location,
                    this.IsFurnished ? "Yes" : "No",
                    this.Width,
                    this.Height);
        }
    }
}
