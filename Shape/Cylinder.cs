using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cylinder : Circle,VolumeInterface //圆柱体
{
    //柱体高
    private double h;
    //赋值柱体高
    public double H
    {
        get { return this.h; }
        set { this.h = value; }
    }
    // 无参构造函数,调用三个参数的基类构造类
    public Cylinder() : base(0,0,1)
    {
        base.X = base.Y = 0;
        base.R = 1;
        this.H = 1;
    }
    // 参数为高
    public Cylinder(double h) : base(0, 0, 1)
    {

        base.X = base.Y = 0;
        base.R = 1;
        this.H = h;
    }
    // 参数为半径与高
    public Cylinder(double radius, double h) : base(new Point(0, 0), radius)
    {
        base.X = base.Y = 0;
        base.R = radius;
        this.H = h;
    }
    // 参数为XY半径与高
    public Cylinder(double x,double y, double radius,double h):base(x, y, radius)
    {
        base.X = x;
        base.Y = y;
        base.R = radius;
        this.H = h;
    }
    // 参数为点半径与高
    public Cylinder(Point point,double radius,double h):base(point, radius)
    {
        base.X = point.X;
        base.Y = point.Y;
        base.R = radius;
        this.H = h;
    }
    // 参数为点高
    public Cylinder(Point point, double h) : base(point, 1)
    {
        base.X = point.X;
        base.Y = point.Y;
        base.R = 1;
        this.H = h;
    }
    //返回柱体的周长，柱体没有周长
    public new double Perimeter()
    {
        return 0;
    }
    //计算柱体的面积
    public override double Area()
    {
        return 2 * Math.PI * base.R * (base.R + this.h);

    }
    //计算柱体的体积
    public double Volume()
    {
        return Math.PI * Math.Pow(base.R, 2) * this.h;
    }
    public override string ToString()
    {
        return "底面圆心坐标 = [" + base.X + "]" + "[" + base.Y + "] ,半径 = " + base.R + ",高 = " + h;
    }

    ~Cylinder() { }
}

