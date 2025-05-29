using LB6_2;

class Program
{
    static void Main()
    {
        List<GeometricFigure> figures = new List<GeometricFigure>
        {
            new Circle(5) { Name = "Circle A" },
            new Oval(3, 7) { Name = "Oval B" },
            new Triangle(3, 4, 5) { Name = "Triangle C" },
            new Circle(2) { Name = "Circle D" },
            new Oval(5, 2) { Name = "Oval E" },
            new Triangle(6, 8, 10) { Name = "Triangle F" }
        };
        Console.Write("Введите минимальную площадь: ");
        if (double.TryParse(Console.ReadLine(), out double minArea))
        {
            var result = figures
                .Where(f => f.CalculateArea() >= minArea)
                .ToList();

            Console.WriteLine($"\nФигуры с площадью не меньше {minArea}:");
            foreach (var figure in result)
            {
                Console.WriteLine($"{figure.Name} ({figure.GetType().Name})");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
        }
        Console.ReadKey();
    }
}
