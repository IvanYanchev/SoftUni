using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The title cannot be null.");
                }
                else
	            {
                    this.title = value;
	            }
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The author cannot be null.");
                }
                else
                {
                    this.author = value;
                }
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The prise cannot be negative number.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            string bookInfo = string.Format("-Type: {0}\n\r-Title: {1}\n\r-Author: {2}\n\r-Price: {3}", this.GetType().Name, this.Title, this.Author, this.Price);
            return bookInfo;
        }
    }
}
