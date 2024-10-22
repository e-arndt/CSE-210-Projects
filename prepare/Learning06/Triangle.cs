public class Triangle : Shape
{
    private double _base;
    private double _height;


    public Triangle(string color, double tbase, double height) : base (color)
    {
        _base = tbase;
        _height = height;
    }


    public override double GetArea()
    {
        return (_height * _base) / 2;
    }



}