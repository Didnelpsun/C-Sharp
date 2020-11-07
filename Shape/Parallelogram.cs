using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Parallelogram:Trapaezoid//平行四边形
{
    //计算对应边的高
    private double h1;
    private double h2;

    public double H1
    {
        get { return this.h1; }
    }

    public double H2
    {
        get { return this.h2; }
    }

    private void Handle()
    {
        if (this.pl1 && this.pl2)
        {
            if (this.IsVevrtical(this.l1, this.l2))
            {
                this.h1 = this.l2.Length();
                this.h2 = this.l1.Length();
            }
            else
            {
                this.h1 = this.l2.Length() * Math.Sin(this.LineAngle(this.l1, this.l2));
                this.h2 = this.l3.Length() * Math.Sin(this.LineAngle(this.l3, this.l2));
            }
        }
        else
        {
            throw new Exception("输入的点不构成两对平行关系");
        }
    }

    public Parallelogram() { }

    public Parallelogram(Point point1, Point point2, Point point3, Point point4) : base(point1, point2, point3, point4)
    {
        this.Handle();
    }

    public Parallelogram(Line line1, Line line2, Line line3, Line line4) : base(line1, line2, line3, line4)
    {
        this.Handle();
    }

    public override string ToString()
    {
        return "该平行四边形" + base.ToString();
    }

    ~Parallelogram() { }
}

