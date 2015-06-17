using System;
using System.Collections.Generic;

struct Location
{
    private double lattitude;
    private double longitude;
    private Planet planet;

    public Location(double lattitude, double longitude, Planet planet)
        :this()
    {
        this.Lattitude = lattitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public double Lattitude
    {
        get
        {
            return this.lattitude;
        }
        set
        {
            this.lattitude = value;
        }
    }
    public double Longitude
    {
        get
        {
            return this.longitude;
        }
        set
        {
            this.longitude = value;
        }
    }
    public Planet Planet
    {
        get
        {
            return this.planet;
        }
        set
        {
            this.planet = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0:f6}, {1:f6} - {2}", this.Lattitude, this.Longitude, this.Planet);
    }
}