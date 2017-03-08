namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.GetShape("Circle");
            circle.Draw();

            var triangle = shapeFactory.GetShape("Triangle");
            triangle.Draw();

            var square = shapeFactory.GetShape("Square");
            square.Draw();
        }
    }
}
