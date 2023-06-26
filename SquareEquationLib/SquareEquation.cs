namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double eps = 1e-9;
        if (a==0 || a==double.NaN || a==double.NegativeInfinity || a==double.PositiveInfinity || 
        b==double.NaN || b==double.NegativeInfinity || b==double.PositiveInfinity || 
        c==double.NaN || c==double.NegativeInfinity || c==double.PositiveInfinity || 
        Double.IsInfinity(a) || Double.IsInfinity(b) || Double.IsInfinity(c)) throw new System.ArgumentException();
        double[] o = new double[] {};
        double d;
        d=b*b-4*c*a;
        double x1, x2;
        if (Math.Abs(d)<eps)
        {
            o = new double[1];
            o[0] = -b/2;
        }
        if (d>=eps)
        {
            o = new double[2];
            x1=-(b+Math.Sign(b)*Math.Sqrt(d))/2;
            x2=c/x1;
            o[0] = x1;
            o[1] = x2;
        }
        
        
        return o;
    }
}
