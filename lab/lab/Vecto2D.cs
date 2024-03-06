using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Vecto2D : IVecto
    {
        private float x; 
        private float y;

        public Vecto2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        //Tính Module
        public double Module()
        {

            double result = Math.Round(Math.Sqrt(x * x + y * y), 2);
            return result;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        //Chuyen 2D sang 3D: Toán tử ~
        public static IVecto operator ~(Vecto2D v)
        {
            return new Vecto3D(v.x, v.y, 0);
        }

        //Toán tử +
        public static IVecto operator +(Vecto2D a, Vecto2D b)
        {
            return new Vecto2D(a.x + b.x, a.y + b.y);
        }

        //Toán tử *
        public static double operator *(Vecto2D v1, Vecto2D v2)
        {
            return v1.x * v2.x + v1.y*v2.y;
        }

        
    }
}
