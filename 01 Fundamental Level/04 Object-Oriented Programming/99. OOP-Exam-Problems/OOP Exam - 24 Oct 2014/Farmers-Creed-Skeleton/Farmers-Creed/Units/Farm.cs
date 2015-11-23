using System.Linq;
using System.Text;

namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using FarmersCreed.Interfaces;

    public class Farm : GameObject, IFarm
    {
        private List<Plant> plants;
        private List<Animal> animals;
        private List<Product> products;

        public Farm(string id)
            : base(id)
        {
            this.plants = new List<Plant>();
            this.animals = new List<Animal>();
            this.products = new List<Product>();
        }

        public List<Plant> Plants
        {
            get { return this.plants; }
        }

        public List<Animal> Animals
        {
            get { return this.animals; }
        }

        public List<Product> Products
        {
            get { return this.products; }
        }

        public void AddProduct(Product product)
        {
            var existingProduct = this.Products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                this.Products.Add(product);
            }
        }

        public void Exploit(IProductProduceable productProducer)
        {
            this.AddProduct(productProducer.GetProduct());
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            String foodId = ((Food)edibleProduct).Id;
            this.products.Find(p => p.Id == foodId).Quantity -= productQuantity;
            animal.Eat(edibleProduct, productQuantity);
        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            foreach (Animal animal in this.Animals)
            {
                animal.Starve();
            }

            foreach (Plant plant in this.Plants)
            {
                if (!plant.HasGrown)
                {
                    plant.Grow();
                }
                else
                {
                    plant.Wither();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("--{0} {1}", this.GetType().Name, this.Id);
            sb.AppendLine();

            foreach (Animal animal in this.Animals.OrderBy(a => a.Id))
            {
                if (animal.IsAlive)
                {
                    sb.AppendLine(animal.ToString());
                }
            }

            foreach (Plant plant in this.Plants.OrderBy(p => p.Health).ThenBy(p => p.Id))
            {
                if (plant.IsAlive)
                {
                    sb.AppendLine(plant.ToString());
                }
            }

            foreach (Product product in this.Products.OrderBy(p => p.ProductType.ToString()).ThenByDescending(p => p.Quantity).ThenBy(p => p.Id))
            {
                sb.AppendLine(product.ToString());
            }

            return sb.ToString();
        }
    }
}
