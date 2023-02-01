class Rectangle
{
    private double length;
    private double width;

    public Rectangle()
    {
        this.length = 0;
        this.width = 0;
    }

    public double Length
    {
        get{return length;}
        set{length = value;}
    }

    public double Width
    {
        get{return width;}
        set{width = value;}
    }

    public virtual double GetArea()
    {
        return length * width;
    }

    public virtual double GetPerimeter()
    {
        return (2 * length) + (2 * width);
    }
}