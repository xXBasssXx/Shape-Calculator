class Square : Rectangle
{
    private double side;

    public Square()
    {
        this.side = 0;
    }

    public double Side
    {
        get{return side;}
        set{side = value;}
    }

    public override double GetArea()
    {
        return Math.Pow(side, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}