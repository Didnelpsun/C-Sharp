using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rhombus:Parallelogram//菱形
{
    public Rhombus() { }
    public Rhombus(Point point1, Point point2, Point point3, Point point4) : base(point1, point2, point3, point4)
    {
        if (!this.IsLineEqual())
        {
            throw (new Exception("输入的点构成的边长度不全等"));
        }
    }

    public Rhombus(Line line1, Line line2, Line line3, Line line4) : base(line1, line2, line3, line4)
    {
        if (!this.IsLineEqual())
        {
            throw (new Exception("输入的边长度不全等"));
        }
    }

    public override string ToString()
    {
        return "该菱形" + base.ToString();
    }

    ~Rhombus() { }
}
