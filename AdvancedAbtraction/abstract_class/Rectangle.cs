

namespace AdvancedAbtraction.abstract_class;

public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public Rectangle(double height, double width, string color):base(color)
    {
       this.Width = width;
       this.Height = height;   
    }

    public override double GetArea() => Height * Width;
    public override double GetPerimetter() => (Height + Width)*2;

    public override void Display()
    {
        Console.WriteLine($"Height is: {Height}, Width is: {Width}, Color is: {Color}...");

    }
}
