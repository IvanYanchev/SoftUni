using Estates.Interfaces;

namespace Estates.Data
{
    public class House : Estate, IHouse
    {
        public int Floors { get; set; }

        public override string ToString()
        {
            return
                string.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, Floors: {5}",
                this.GetType().Name,
                this.Name,
                this.Area,
                this.Location,
                this.IsFurnished ? "Yes" : "No",
                this.Floors);
        }
    }
}
