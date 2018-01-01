using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your venue?");
        Venue venue = new Venue();
        venue.Name = "The Jazz Hut";
        venue.AddBand("Jazztallica");
        venue.AddBand("Jazzadeth");
        venue.Announce();
    }
}
