using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Векторы
{
    struct vector
    {
        public double X;
        public double Y;
        public double Z;

        public vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static vector operator +(vector A, vector B)
        {
            vector result = new vector();

            result.X = A.X + B.X;
            result.Y = A.Y + B.Y;
            result.Z = A.Z + B.Z;

            return result;
        }

        public static vector operator -(vector A, vector B)
        {
            vector result = new vector();

            result.X = A.X - B.X;
            result.Y = A.Y - B.Y;
            result.Z = A.Z - B.Z;

            return result;
        }

        public void Show()
        {
            Console.WriteLine($"{X}, {Y}, {Z}");
        }
    }

    class Vector
    {
        public vector A { get; set; }

        public vector MultiplicationByNumber(double num)
        {
            return new vector(num * A.X, num * A.Y, num * A.Z);
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(A.X, 2) + Math.Pow(A.Y, 2) + Math.Pow(A.Z, 2));
        }

        public static vector Sum(vector A, vector B)
        {
            return new vector(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        public static vector Difference(vector A, vector B)
        {
            return new vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        public static double Scalar(vector A, vector B)
        {
            return A.X * B.X + A.Y * B.Y + A.Z * B.Z;
        }
    }
    
}
