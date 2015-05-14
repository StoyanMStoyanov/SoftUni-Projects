using System;

class TorrentPirate
{
    static void Main()
    {
        decimal data = decimal.Parse(Console.ReadLine());
        decimal priceOfCinema = decimal.Parse(Console.ReadLine());
        decimal moneyPerHour = decimal.Parse(Console.ReadLine());

        decimal downloadTime = data / 7200;
        decimal priceForDownload = downloadTime * moneyPerHour;
        decimal numberOfMovies = data / 1500;
        decimal cinemaPrice = numberOfMovies * priceOfCinema;

        Console.WriteLine("{0}", priceForDownload > cinemaPrice ? 
            string.Format("cinema -> {0:f2}lv", cinemaPrice) : string.Format("mall -> {0:f2}lv", priceForDownload));
    }
}
