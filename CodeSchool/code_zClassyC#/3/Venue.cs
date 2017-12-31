using System;

public class Venue
{
    public string Name;
    //public Band[] Bands = new Band[2]; // array
      public List<Band> Bands = new List<Band>(); // list

    public void AddBand(string name)
    {
        Band band = new Band();
        band.Name = name;
        // Bands[0] = band;    // array
           Bands.Add(band);    // list
    
    }

    public void Announce()
    {
        Console.WriteLine(Name + " will have several bands playing tonight!");
    }
}
