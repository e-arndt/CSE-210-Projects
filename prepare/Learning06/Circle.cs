public class Circle : Shape
{
    private double _rad;


    public Circle(string color, double rad) : base (color)
    {
        _rad = rad;
    }


    public override double GetArea()
    {
        double rawArea = (22/7.0028174985) * (_rad * _rad);
        double cArea = Math.Round(rawArea, 2);
        return cArea;
    }



}