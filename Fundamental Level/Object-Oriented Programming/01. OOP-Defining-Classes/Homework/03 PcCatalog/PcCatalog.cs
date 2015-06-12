using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class PcCatalog
    {
        static void Main(string[] args)
        {
            Component mb1 = new Component("ASROCK K7S41GX2 /SIS741GX", 52.50);
            Component mb2 = new Component("GB 990FXA-UD5 /AMD 990FX/AM3+", 149.00);
            Component mb3 = new Component("ASUS A88X-PRO /FM2+", 116.00);
            Component mb4 = new Component("SM MBD-X9DRD-IF /C602/LGA2011", 425.00);

            Component cpu1 = new Component("I3-3250 3.5GHZ/3MB/LGA1155/BOX", 122.50);
            Component cpu2 = new Component("I5-4590 /3.3G/6MB/BOX/LGA1150", 221.00);
            Component cpu3 = new Component("AMD FX-8350/4.2G/X8/BOX/AM3+", 203.00);

            Component ram1 = new Component("2X2G DDR3 1600 ADATA", 34.30);
            Component ram2 = new Component("2X4G DDR3 3000 GEIL EVOPOTENZW", 452.00);
            Component ram3 = new Component("8G DDR3 1333 KINGST HYPER FURY", 69.10);


            Component hdd1 = new Component("500G SG SATA 6G/7200/16M", 53.20);
            Component hdd2 = new Component("KINGSTON SSD M2 2280 S3 / 240G", 146.00);
            Component hdd3 = new Component("1T SG ST1000VX001 64MB", 62.00);
            Component hdd4 = new Component("5TB SG ARCHIVE /128MB ENCRYPT", 180.00);


            Component vid1 = new Component("GB N75TWF2BK-2GI /GTX750 TI 2G", 165.00);
            Component vid2 = new Component("SAPPFIRE R9 290X 8G GD5 OC TRX", 422.00);
            Component vid3 = new Component("PALIT GTX960 JETSTREAM 4G GD5", 245.00);
            Component vid4 = new Component("ASUS GT730-SL-2GD3-BRK", 60.00);

            Component case1 = new Component("NZXT SOURCE 340/MID TOWER/WH", 70.16);
            Component case2 = new Component("OMEGA ATX-8815BK /450W 12CM/BK", 31.10);
            Component case3 = new Component("CM SILENCIO 650 PURE", 81.00);

            

            List<Computer> pcs = new List<Computer>();
            pcs.Add(new Computer("PESHO", mb1, cpu2, ram1, hdd2, vid3, case1));
            pcs.Add(new Computer("GOSHO", mb2, cpu3, ram3, hdd4, vid1, case3));
            pcs.Add(new Computer("VIPER", mb4, cpu1, ram2, hdd1, vid2, case2));
            pcs.Add(new Computer("WORKSTATION", mb3, cpu2, ram3, hdd3, vid4, case1));

            foreach (var pc in pcs.OrderBy(x => x.Price))
            {
                pc.PrintInfo();
            }
        }
    }
}
