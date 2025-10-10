public class Rectangle : Shape
{
    private double _width;
    private double _height;
    private string v1;
    private double v2;
    private double v3;

    public Rectangle(double width, double height, string color)
    {
        _width = width;
        _height = height;
        SetColor(color);
    }

    public Rectangle(string v1, double v2, double v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}