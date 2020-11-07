using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Point point = new Point(5, 7);
        Console.WriteLine("点的坐标为{0}", point.ToString());
        Circle circle = new Circle(point, 2.5);
        Console.WriteLine(circle.ToString());
        Console.WriteLine("圆周长为{0}，面积为{1}", circle.Perimeter(), circle.Area());
        Cylinder cylinder = new Cylinder(point, 3, 6);
        Console.WriteLine(cylinder.ToString());
        Console.WriteLine("圆柱体面积为{0}，体积为{1}", cylinder.Area(), cylinder.Volume());
        Point point1 = new Point(0, 0);
        Point point2 = new Point(0, 2);
        Point point3 = new Point(3, 0);
        Triangle triangle = new Triangle(point1, point2, point3);
        Console.WriteLine(triangle.ToString());
        Console.WriteLine("三角形周长为{0}，面积为{1}", triangle.Perimeter(), triangle.Area());
        string s1 = triangle.IsEquicrural() ? "是" : "不是";
        string s2 = triangle.IsEquilateral() ? "是" : "不是";
        Console.WriteLine("三角形" + s1 + "等腰三角形，" + s2 + "等边三角形");
        Point point4 = new Point(3, 4);
        Trapaezoid trapaezoid = new Trapaezoid(point1, point2, point4, point3);
        Console.WriteLine(trapaezoid.ToString());
        Console.WriteLine("梯形周长为{0}，面积为{1}，高为{2}", trapaezoid.Perimeter(), trapaezoid.Area(), trapaezoid.H);
        Console.WriteLine(trapaezoid.WhichParallel());
        Point point5 = new Point(3, 2);
        Parallelogram parallelogram = new Parallelogram(point1, point2, point5, point3);
        Console.WriteLine(parallelogram.ToString());
        Console.WriteLine("平行四边形周长为{0}，面积为{1}，两个高为{2}，{3}", parallelogram.Perimeter(), parallelogram.Area(), parallelogram.H1, parallelogram.H2);
        Point point6 = new Point(1, 0);
        Point point7 = new Point(0, 5);
        Point point8 = new Point(1, 10);
        Point point9 = new Point(2, 5);
        Rhombus rhombus = new Rhombus(point6, point7, point8, point9);
        Console.WriteLine(rhombus.ToString());
        Console.WriteLine("菱形周长为{0}，面积为{1}，两个高为{2}，{3}", rhombus.Perimeter(), rhombus.Area(), rhombus.H1, rhombus.H2);
        Rectangle rectangle = new Rectangle(point1, point2, point5, point3);
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine("长方形周长为{0}，面积为{1}", rectangle.Perimeter(), rectangle.Area());
        Point point10 = new Point(2, 2);
        Point point11 = new Point(2, 0);
        Quadrate quadrate = new Quadrate(point1, point2, point10, point11);
        Console.WriteLine(quadrate.ToString());
        Console.WriteLine("正方形周长为{0}，面积为{1}", quadrate.Perimeter(), quadrate.Area());
        Console.ReadLine();
    }
}
