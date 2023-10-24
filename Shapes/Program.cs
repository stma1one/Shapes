namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(4, "red");
            Circle c2 = new Circle(4, "Circle", "Red");
            Square sq = new Square(5, "Brown");

            Shape[] shapes = { c1, c2, sq };
            
            Console.WriteLine( sq.Area() );
        }
    }
    
}