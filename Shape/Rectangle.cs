using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle:Parallelogram//长方形
{
    public Rectangle(Point point1, Point point2, Point point3, Point point4) : base(point1, point2, point3, point4)
    {
        if (!this.IsVevrtical(this.l1, this.l2))
        {
            throw (new Exception("输入的点构成的边不构成直角"));
        }
    }
    public Rectangle(Line line1, Line line2, Line line3, Line line4) : base(line1, line2, line3, line4)
    {
        if (!this.IsVevrtical(this.l1, this.l2))
        {
            throw (new Exception("输入的点构成的边不构成直角"));
        }
    }

    public override string ToString()
    {
        return "该长方形" + base.ToString();
    }

    ~Rectangle() { }
}

