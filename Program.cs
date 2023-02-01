namespace Shape_Calculator;
class Program
{
    static void Main(string[] args)
    {
        int choice;

        Console.WriteLine("Shape Calculator\n");
        Console.WriteLine("[1] - Circle");
        Console.WriteLine("[2] - Rectangle");
        Console.WriteLine("[3] - Square");

        choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Circle c = new Circle();
                Console.Write("Enter radius of the Circle: ");
                c.Radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Area of Circle is {c.GetArea(): 0.00}");
                break;
            case 2:
                Rectangle r = new Rectangle();
                Console.Write("Enter length of the Rectangle: ");
                r.Length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width of the Rectangle: ");
                r.Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Area of Rectangle is {r.GetArea(): 0.00}");
                Console.WriteLine($"Perimeter of Rectangle is {r.GetPerimeter(): 0.00}");
                break;
            case 3:
                Square s = new Square();
                Console.Write("Enter side of the Square: ");
                s.Side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Area of Rectangle is {s.GetArea(): 0.00}");
                Console.WriteLine($"Perimeter of Rectangle is {s.GetPerimeter(): 0.00}");
                break;
            default: Console.WriteLine("Wrong Input!");
                break;
        }
    }
}
