namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            Shape circle = new Circle(5);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
            Shape rectangle = new Rectangle(5, 6);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

        }
    }
}