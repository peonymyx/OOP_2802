using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Vecto3D : IVecto
    {
        private float x;
        private float y;
        private float z;

        //Constructor
        public Vecto3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        //Tính Module
        public double Module()
        {
            double result = Math.Round(Math.Sqrt(x * x + y * y + z * z), 2);
            return result;
        }

        //Chuyển 3D sang 2D: Toán tử ~
        public static IVecto operator ~(Vecto3D v)
        {
            return new Vecto2D(v.x, v.y);
        }

        //Toán tử +
        public static IVecto operator +(Vecto3D a, Vecto3D b)
        {
            return new Vecto3D(a.x + b.x, a.y + b.y , a.z + b.z);
        }

        //Toán tử *
        public static double operator *(Vecto3D v1, Vecto3D v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        
    }
}
