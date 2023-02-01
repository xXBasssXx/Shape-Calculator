class Circle
{
    private double radius;

    public Circle()
    {
        this.radius = 0;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double Radius
    {
        get{return radius;}
        set{radius = value;}
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}