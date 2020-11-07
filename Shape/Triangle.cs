using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

public sealed class Triangle:Shape //Triangle类，包含三个Point，采用sealed,表示是继承树的根类
{
    private Point p1;
    private Point p2;
    private Point p3;

    public class LineInstance : Line { } 

    Line l1 = new LineInstance();//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2 = new LineInstance();
    Line l3 = new LineInstance();

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
   

    //用点初始化Triangle类的实例
    public Triangle(Point point1, Point point2, Point point3)
    {
        this.P1 = point1;
        this.P2 = point2;
        this.P3 = point3;
        //将点赋值到对应的三条线上
        this.l1.P1 = point1;
        this.l1.P2 = point2;
        this.l2.P1 = point2;
        this.l2.P2 = point3;
        this.l3.P1 = point3;
        this.l3.P2 = point1;
    }

    //用线初始化Triangle类的实例
    public Triangle(Line line1, Line line2, Line line3)
    {
        if (line1.P1 == line3.P2 && line1.P2 == line2.P1 && line2.P2 == line3.P1)
        {
            this.l1 = line1;
            this.l2 = line2;
            this.l3 = line3;
            this.P1 = this.l1.P1;
            this.P2 = this.l1.P2;
            this.P3 = this.l2.P2;
        }
        else
        {
            throw (new Exception("定义三角形顶点不一致！"));
        }
    }

    //返回三角形的周长
    public override double Perimeter()
    {
       return l1.Length() + l2.Length() + l3.Length();
    }

    //返回三角形的面积
    public override double Area() 
    {
        double p = this.Perimeter()/2;
        return Math.Sqrt(p * (p - l1.Length()) * (p - l2.Length()) * (p - l3.Length()));
    }

    public bool IsEquicrural()//判断是否为等腰三角形
    {
        return l1.Length() == l2.Length() ? true : (l1.Length() == l3.Length() ? true : (l2.Length() == l3.Length() ? true : false));
    }

    public bool IsEquilateral()//判断是否为等边三角形
    {
        return l1.Length() == l2.Length() && l1.Length() == l3.Length() && l2.Length() == l3.Length();
    }

    public override string ToString()
    {
        return "该三角形点坐标：[" + this.p1.X + "," + this.p1.Y + "]," + "[" + this.p2.X + "," + this.p2.Y + "]," + "[" + this.p3.X + "," + this.p3.Y + "]，三边长度：" + this.l1.Length() + " " + this.l2.Length() + " " + this.l3.Length();
    }

    ~Triangle() { }
}