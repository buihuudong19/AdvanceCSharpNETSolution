namespace AdvancedAbtraction.abstract_class;

public abstract class Shape
{
    public string? Color { get; set; }
    public Shape() { }

    protected Shape(string? color)
    {
        Color = color;
    }

    //if a method press virtual keywork then sub-class can be overriden if nescessary 
    public virtual void Display()
    {
        Console.WriteLine($"Color is: {Color}");
    }
    public abstract double GetArea();//signature
    public abstract double GetPerimetter();

}


