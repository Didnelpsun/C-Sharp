using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trapaezoid:Quadrilateral//梯形类
{
    //pl1为0代表13边不平行，1代表平行，pl2为0代表24边不平行，1代表平行
    protected bool pl1 = false;
    protected bool pl2 = false;
    //高
    private double h;

    public double H
    {
        get { return this.h; }
    }

    public Trapaezoid() { }

    private void Handle()
    {
        // 如果边存在一对平行
        if (this.IsParallel(this.l1, this.l3) || this.IsParallel(this.l2, this.l4))
        {
            if (this.IsParallel(this.l1, this.l3))
            {
                this.pl1 = true;
            }
            if (this.IsParallel(this.l2, this.l4))
            {
                this.pl2 = true;
            }
            this.h = this.ComputeH();
        }
        else
        {
            throw (new Exception("输入的点不存在一对平行关系！"));
        }
    }

    public Trapaezoid(Point point1, Point point2, Point point3, Point point4):base(point1, point2, point3, point4)
    {
        this.Handle();
    }

    public Trapaezoid(Line line1, Line line2, Line line3, Line line4):base( line1, line2, line3, line4)
    {
        this.Handle();
    }

    public double ComputeH()
    {
        if (this.pl1)
        {
            if (this.IsVevrtical(this.l1, this.l2))
            {
                return this.l2.Length();
            }
            else if (this.IsVevrtical(this.l1, this.l4))
            {
                return this.l4.Length();
            }
            else
            {
                return this.l2.Length() * Math.Sin(this.LineAngle(this.l1, this.l2));
            }
        }
        else
        {
            if (this.IsVevrtical(this.l2, this.l1))
            {
                return this.l1.Length();
            }
            else if (this.IsVevrtical(this.l2, this.l3))
            {
                return this.l3.Length();
            }
            else
            {
                return this.l3.Length() * Math.Sin(this.LineAngle(this.l3, this.l2));
            }
        }
    }

    public override double Area()
    {
        if(this.pl1)
        {
            return (this.l1.Length() + this.l3.Length()) / 2 * this.h;
        }
        else
        {
            return (this.l2.Length() + this.l4.Length()) / 2 * this.h;
        }
    }

    public string WhichParallel()
    {
        int num = Convert.ToInt32(this.pl1) + Convert.ToInt32(this.pl2);
        string s1 = this.pl1 == true ? "第一三边" : "";
        string s2 = this.pl2 == true ? "第二四边" : "";
        return "该梯形共有" + num + "条边为平行边，其中" + s1 + s2 + "为平行边";
    }

    public override string ToString()
    {
        return "该梯形" + base.ToString();
    }
    
    ~Trapaezoid() { }
}

