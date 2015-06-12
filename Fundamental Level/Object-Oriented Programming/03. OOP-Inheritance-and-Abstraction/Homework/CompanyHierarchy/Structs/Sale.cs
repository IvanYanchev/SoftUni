using System;

namespace CompanyHierarchy.Structs
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private double price;

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("Date: {0}, Product: {1}, Price: {2}\r\n", this.Date.ToShortDateString(), this.ProductName, this.Price);
        }
    }
}
