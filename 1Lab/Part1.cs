using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("\nЗадание #1\n");
        Console.WriteLine("Вывод на консоль минимального и максимального значения для предопределенных типов данных CTS");
        Console.WriteLine("Byte: {0} до {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("Sbyte: {0} до {1}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("Short: {0} до {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("Ushort: {0} до {1}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("Int: {0} до {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("Uint: {0} до {1}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("Long: {0} до {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("Ulong: {0}  до {1}", ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("Decimal: {0} до {1}", decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("Float: {0} до {1}", float.MinValue, float.MaxValue);
        Console.WriteLine("Double: {0} до {1}", double.MinValue, double.MaxValue);
        Console.WriteLine("Char: {0} до {1}", char.MinValue, char.MaxValue);


        Console.WriteLine("\n\nЗадание #2\n");
        double a, b;
        Console.WriteLine("Это программа для подсчета площади и периметра прямоугольника.");
        Console.WriteLine("Введи необходимые параметры!");
        Console.WriteLine("Длина прямоугольника:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ширина прямоугольника:");
        b = Convert.ToDouble(Console.ReadLine());
        Rectangle rec = new Rectangle(a, b);
        Console.WriteLine("Площадь прямоугольника = {0}", rec.Area);
        Console.WriteLine("Периметр прямоугольника = {0}", rec.Perimeter);


        Console.WriteLine("\n\nЗадание #3\n");
        Console.WriteLine("Точки (0, 0) (3, 0) (3, 3) (0, 3) ");
        Figure figure = new Figure(new Point(0, 0), new Point(3, 0), new Point(3, 3), new Point(0, 3));
        Console.WriteLine();
    
    }
}

/// <summary>

/// </summary>

class Rectangle
{
    private double side1, side2;

    public Rectangle(double sideA, double sideB)
    {
        if (sideA < 0)
        {
            Console.WriteLine("Значение стороны не может быть меньше нуля!");
            sideA = 0;
        }
        if (sideB < 0)
        {
            Console.WriteLine("Значение стороны не может быть меньше нуля!");
            sideB = 0;
        }
        side1 = sideA;
        side2 = sideB;
    }

    private double CalculateArea()
    {
        return side1 * side2;
    }

    private double CalculatePerimeter()
    {
        return (side1 + side2) * 2;
    }

    public double Area
    {
        get { return this.CalculateArea(); }
    }

    public double Perimeter
    {
        get { return this.CalculatePerimeter(); }
    }
}




/// <summary>

/// </summary>
public class Point
{
    private double x, y;

    public Point(double x1, double y1)
    {
        x = x1;
        y = y1;
    }
    public double X => x;
    public double Y => y;

}

public class Figure
{

    List<Point> Points = new List<Point>();
    public double P { get; set; }
    public Figure(params Point[] points) 
    {
        Points.AddRange(points);
        PerimeterCalculator();
    }

    private static double LengthSide(Point A, Point B) =>
        Math.Sqrt(Math.Pow(Math.Abs(A.X - B.X), 2) + Math.Pow(Math.Abs(A.Y - B.Y), 2));
    
    private void PerimeterCalculator()
    {
        string name = "";
        for (int i = 0; i < Points.Count; i++)
        {
            if (i == Points.Count - 1)
            {
                P += LengthSide(Points[0], Points[i]);
                break;
            }
            P += LengthSide(Points[i], Points[i + 1]);
            
        }
        if (Points.Count == 3)
        { name = "Треугольника"; } 
        else if (Points.Count == 4) 
        { name = "Четырехугольника"; }
        else if (Points.Count == 5)
        { name = "Пятиугольника"; }

        Console.WriteLine("Периметр {0} =  {1} ", name ,P);
    }
}

