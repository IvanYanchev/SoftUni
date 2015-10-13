using System;

namespace Problem_1___Torrent_Pirate
{
    public class TorrentPirate
    {
        static void Main()
        {
            const int DownloadSpeed = 2;
            const int movieSize = 1500;

            int d = int.Parse(Console.ReadLine()); // download megabytes
            int p = int.Parse(Console.ReadLine()); // price to go to cinema
            int w = int.Parse(Console.ReadLine()); // money per hour wife is spending

            double downloadTime = (double)d / (double)DownloadSpeed; // seconds
            downloadTime = downloadTime / (double)3600; //hours
            double downloadPrice = downloadTime * w;

            double numberOfMovies = (double)d / movieSize;

            double cinemaPrice = numberOfMovies * p;

            string placeToGo = "cinema";
            double lowerPrice = cinemaPrice;

            if (downloadPrice <= cinemaPrice)
            {
                placeToGo = "mall";
                lowerPrice = downloadPrice;
            }

            Console.WriteLine("{0} -> {1:F2}lv", placeToGo, lowerPrice);
        }
    }
}
