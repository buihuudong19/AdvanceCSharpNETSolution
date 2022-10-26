using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAbtraction.interfaces;
//multiple (da)
public class Circle : IShape,IPresentation
{
    public double Radius { get; set; }

    public Circle() {  }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public string Display() => $"The circle with Radis: {Radius} and Area: {GetArea()}, Perrimetter: {GetPerimetter()}";
    

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimetter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string? ToString()
    {
        return Display();
    }
}
