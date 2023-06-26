namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        if (a==0 || a==double.NaN || a==double.NegativeInfinity || a==double.PositiveInfinity || 
        b==double.NaN || b==double.NegativeInfinity || b==double.PositiveInfinity || 
        c==double.NaN || c==double.NegativeInfinity || c==double.PositiveInfinity) throw new System.ArgumentException();
        double d;
        d=b*b-4*c;
        if (d<0) return new double[0];
        double x1, x2;
        x1=-(b+Math.Abs(b)*Math.Sqrt(d))/2;
        x2=c/x1;
        double[] o0 = new double[1];
        o0[0] = x1;
        double[] o = new double[2];
        o[0] = x1;
        o[1] = x2;
        if (d==0) return o0;
        return o;
    }
}
