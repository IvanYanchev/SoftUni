using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;
using FarmersCreed.Units;

namespace FarmersCreed.Simulator
{
    public class MyFarmSimulator : FarmSimulator
    {
        protected override void ProcessInput(string input)
        {
            string[] inputCommands = input.Split(' ');

            string action = inputCommands[0];

            switch (action)
            {
                case "create":
                    {
                        string farmId = inputCommands[1];
                        this.farm = new Farm(farmId);
                    }
                    break;
                case "add":
                    {
                        this.AddObjectToFarm(inputCommands);
                    }
                    break;
                case "status":
                    {
                        this.PrintObjectStatus(inputCommands);
                    }
                    break;
                case "feed":
                    {
                        this.farm.Feed(this.GetAnimalById(inputCommands[1]), (IEdible)this.GetProductById(inputCommands[2]), int.Parse(inputCommands[3]));
                    }
                    break;
                case "water":
                    {
                        this.farm.Water(this.GetPlantById(inputCommands[1]));
                    }
                    break;
                case "exploit":
                    {
                        String id = inputCommands[2];
                        switch (inputCommands[1])
                        {
                            case "animal":
                                this.farm.Exploit(this.GetAnimalById(id));
                                break;
                            case "plant":
                                this.farm.Exploit(this.GetPlantById(id));
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void PrintObjectStatus(string[] inputCommands)
        {
            string objectType = inputCommands[1];

            switch (objectType)
            {
                case "farm":
                    {
                        Console.WriteLine(this.farm);
                    }
                    break;
                case "plant":
                    {
                        var plant = this.GetPlantById(inputCommands[2]);
                        Console.WriteLine(plant);
                    }
                    break;
                case "animal":
                    {
                        var animal = this.GetAnimalById(inputCommands[2]);
                        Console.WriteLine(animal);
                    }
                    break;
                case "product":
                    {
                        var product = this.GetProductById(inputCommands[2]);
                        if (product is Food)
                        {
                            Console.WriteLine(product as Food);
                        }
                        else
                        {
                            Console.WriteLine(product);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string type = inputCommands[1];
            string id = inputCommands[2];

            switch (type)
            {
                case "Grain":
                    {
                        var food = new Food(id, ProductType.Grain, FoodType.Organic, 10, 2);
                        this.farm.AddProduct(food);
                    }
                    break;
                case "CherryTree":
                    {
                        var cherryTree = new CherryTree(id);
                        this.farm.Plants.Add(cherryTree);
                    }
                    break;
                case "TobaccoPlant":
                    {
                        var tobaccoPlant = new TobaccoPlant(id);
                        this.farm.Plants.Add(tobaccoPlant);
                    }
                    break;
                case "Cow":
                    {
                        var cow = new Cow(id);
                        this.farm.Animals.Add(cow);
                    }
                    break;
                case "Swine":
                    {
                        var pig = new Swine(id);
                        this.farm.Animals.Add(pig);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
