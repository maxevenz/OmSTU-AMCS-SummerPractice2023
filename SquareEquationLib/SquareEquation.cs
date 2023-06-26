namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double eps = 1e-9;
        if (Math.Abs(a)<eps || (Double.IsNaN(a)) || (Double.IsNaN(b)) || (Double.IsNaN(c)) || 
        (Double.IsNegativeInfinity(a)) || (Double.IsNegativeInfinity(b)) || (Double.IsNegativeInfinity(c)) ||
        (Double.IsPositiveInfinity(a)) || (Double.IsPositiveInfinity(b)) || (Double.IsPositiveInfinity(c)) || 
        (Double.IsInfinity(a)) || (Double.IsInfinity(b)) || (Double.IsInfinity(c))) throw new System.ArgumentException();
        double[] o = new double[] {};
        double d;
        d=b*b-4*c*a;
        double x1, x2;
        if (Math.Abs(d)<eps)
        {
            o = new double[1];
            o[0] = -b/2;
        }
        else if (d>=eps)
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
