using System;
using System.Collections.Generic;
using Points;
using System.Text;

class Path3D
{   
    //Fields
    private List<Decart3DPoint> path;

    //Constructors
    public Path3D()
    {
        path = new List<Decart3DPoint>();
    }
    public Path3D(double x, double y, double z)
        :this()
    {        
        this.path.Add(new Decart3DPoint(x, y ,z));
    }
    public void AddPoint(double x, double y, double z)
    {
        this.path.Add(new Decart3DPoint(x, y, z));
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var point in path)
            sb.AppendLine(point.ToString());
        return sb.ToString();
    }
}

