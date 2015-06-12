using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Battery myLaptopBattery = new Battery("Li-Ion, 6-cells, 2550 mAh", 4.5);

            Laptop myLaptop = new Laptop("G780", 1429.00m);

            myLaptop.Battery = myLaptopBattery;
            myLaptop.Manufacturer = "Lenovo";
            myLaptop.Processor = "Intel Core i7-3612QM 2.10GHz/3.10GHz";
            myLaptop.Ram = 8;
            myLaptop.GraphicsCard = "NVIDIA GeForce GT 635M 2GB";
            myLaptop.Screen = "17.3\" HD 16:9 widescreen (1600x900)";
            myLaptop.Hdd = "1TB (5,400 rpm)";

            Laptop jennysLaptop = new Laptop("HP-mini", 648, manufacturer: "HP", processor: "Intel Atom N455 1.66Ghz (512K L2)", ram: 2);
            jennysLaptop.Battery = new Battery("dead battery", 0);

            Laptop motherInLowsLaptop = new Laptop("Aspire", 899, hdd: "500 GB");

            Console.WriteLine(myLaptop);
            Console.WriteLine(jennysLaptop);
            Console.WriteLine(motherInLowsLaptop);

        }
    }
}
