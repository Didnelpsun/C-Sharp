using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quadrilateral:Shape//四边形类
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;

    public class LineInstance : Line { }

    protected Line l1 = new LineInstance();//没写访问控制符，相当于默认protected，只能被其派生类使用
    protected Line l2 = new LineInstance();
    protected Line l3 = new LineInstance();
    protected Line l4 = new LineInstance();

    public Point P1
    {
        get { return this.p1; }
        set { this.p1 = value; }
    }

    public Point P2
    {
        get { return this.p2; }
        set { this.p2 = value; }
    }

    public Point P3
    {
        get { return this.p3; }
        set { this.p3 = value; }
    }

    public Point P4
    {
        get { return this.p4; }
        set { this.p4 = value; }
    }

    public double LineAngle(Line line1, Line line2)
    {
        return Math.Atan(Math.Abs((line1.Slope() - line2.Slope()) / (1 + line1.Slope() * line2.Slope())));
    }

    //是否垂直
    public bool IsVevrtical(Line line1, Line line2)
    {
        double x1 = line1.P1.X - line1.P2.X;
        double y1 = line1.P1.Y - line1.P2.Y;
        double x2 = line2.P1.X - line2.P2.X;
        double y2 = line2.P1.Y - line2.P2.Y;
        return x1 * x2 + y1 * y2 == 0;
    }

    //是否平行
    public bool IsParallel(Line line1, Line line2)
    {
        double x1 = line1.P1.X - line1.P2.X;
        double y1 = line1.P1.Y - line1.P2.Y;
        double x2 = line2.P1.X - line2.P2.X;
        double y2 = line2.P1.Y - line2.P2.Y;
        return x1 * y2 - x2 * y1 == 0;
    }

    //四边是否相等
    public bool IsLineEqual()
    {
        if (this.l1.Length() == this.l2.Length())
        {
            if (this.l1.Length() == this.l3.Length())
            {
                if (this.l1.Length() == this.l4.Length())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    //点构造类
    public Quadrilateral() { }
    public Quadrilateral(Point point1, Point point2, Point point3, Point point4)
    {
        this.P1 = point1;
        this.P2 = point2;
        this.P3 = point3;
        this.P4 = point4;
        //将点赋值到对应的四条线上
        this.l1.P1 = point1;
        this.l1.P2 = point2;
        this.l2.P1 = point2;
        this.l2.P2 = point3;
        this.l3.P1 = point3;
        this.l3.P2 = point4;
        this.l4.P1 = point4;
        this.l4.P2 = point1;
    }

    //用线初始化类的实例
    public Quadrilateral(Line line1, Line line2, Line line3, Line line4)
    {
        if (this.l1.P1 == this.l4.P2 && this.l1.P2 == this.l2.P1 && this.l2.P2 == this.l3.P1 && this.l3.P2 == this.l4.P1)
        {
            this.l1 = line1;
            this.l2 = line2;
            this.l3 = line3;
            this.l4 = line4;
            this.P1 = this.l1.P1;
            this.P2 = this.l1.P2;
            this.P3 = this.l2.P2;
            this.P4 = this.l3.P2;
        }
        else
        {
            throw (new Exception("定义四边形顶点不一致！"));
        }
    }

    //返回四边形的周长
    public override double Perimeter()
    {
        return l1.Length() + l2.Length() + l3.Length() + l4.Length();
    }


    public override string ToString()
    {
        return "点坐标：[" + this.p1.X + "," + this.p1.Y + "]," + "[" + this.p2.X + "," + this.p2.Y + "]," + "[" + this.p3.X + "," + this.p3.Y + "]," + "[" + this.p4.X + "," + this.p4.Y + "]，四边长度：" + this.l1.Length() + " " + this.l2.Length() + " " + this.l3.Length() + " " + this.l4.Length();
    }

    ~Quadrilateral() { }
}

