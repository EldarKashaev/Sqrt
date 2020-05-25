using System;

namespace Sqrt
{
    public static class MyMath
    {
        public const double Epsilon = 0.00001;
        public static double Sqrt(double a)
        {
            if (a < 0) throw new ArgumentOutOfRangeException($"{nameof(a)} must be greater than zero");

            double x = a / 2;

            while (Abs(x * x - a) > Epsilon)
            {
                x = (x + a / x) / 2;
            }

            return x;
        }

        public static double Abs(double value)
        {
            return value < 0 ? -value : value;
        }
    }
}