using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class OrdersQueries
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var mp = new DataMapper();
            var allCategories = mp.GetAllCategories();
            var allProducts = mp.GetAllProducts();
            var allOrders = mp.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensiveProducts = allProducts
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProducts = allProducts
                .GroupBy(product => product.CatId)
                .Select(products => new { Category = allCategories.First(category => category.Id == products.Key).Name, Count = products.Count() })
                .ToList();
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine(
                    "{0}: {1}", 
                    item.Category, 
                    item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var topProductsByOrderQuantity = allOrders
                .GroupBy(order => order.ProductId)
                .Select(orders => new { Product = allProducts.First(product => product.Id == orders.Key).Name, Quantities = orders.Sum(order => order.Quantity) })
                .OrderByDescending(product => product.Quantities)
                .Take(5);
            foreach (var item in topProductsByOrderQuantity)
            {
                Console.WriteLine(
                    "{0}: {1}", 
                    item.Product, 
                    item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = allOrders
                .GroupBy(order => order.ProductId)
                .Select(orders => new { catId = allProducts.First(product => product.Id == orders.Key).CatId, price = allProducts.First(product => product.Id == orders.Key).UnitPrice, quantity = orders.Sum(order => order.Quantity) })
                .GroupBy(category => category.catId)
                .Select(grouping => new { CategoryName = allCategories.First(category => category.Id == grouping.Key).Name, TotalQuantity = grouping.Sum(group => group.quantity * group.price) })
                .OrderByDescending(group => group.TotalQuantity)
                .First();
            Console.WriteLine(
                "{0}: {1}", 
                mostProfitableCategory.CategoryName, 
                mostProfitableCategory.TotalQuantity);
        }
    }
}
