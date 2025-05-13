namespace lb6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double areaThreshold = 50.0;
                List<Oval> figures = new List<Oval>
                {
                    new Oval { NameFigure = "Овал 1", Area = 60 },
                    new Circle { NameFigure = "Коло 1", Area = 78.5, Radius = 5 },
                    new GeometricFigure { NameFigure = "Фігура 1", Area = 100, Radius = 7, Numberofangles = 4 },
                    new Triangle { NameFigure = "Трикутник 1", Area = 55, Radius = 3, Numberofangles = 3, A = 3, B = 4, C = 5 },
                    new Oval { NameFigure = "Овал 2", Area = 45 }
                };
                Console.WriteLine($"Фігури з площею не меншою за {areaThreshold}:");
                bool hasResults = false;
                foreach (var figure in figures)
                {
                    if (figure.Area >= areaThreshold)
                    {
                        hasResults = true;
                        Console.WriteLine($"Назва: {figure.NameFigure}, Площа: {figure.Area}");
                    }
                }
                if (!hasResults)
                {
                    Console.WriteLine("Немає фігур, що задовольняють умову.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }
        }
    }
}