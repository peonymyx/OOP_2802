using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public interface IVecto
        
    {
        //Toán tử ~
        public static IVecto operator ~(IVecto v)
        {
            if (v is Vecto2D) return ~(Vecto2D)v;
            else return ~(Vecto3D)v;
        }


        //Toán tử +
        public static IVecto operator +(IVecto v1, IVecto v2)
        {
            if (v1 is Vecto2D && v2 is Vecto2D)
            {
                return (Vecto2D)v1 + (Vecto2D)v2;
            }
            else if (v1 is Vecto3D && v2 is Vecto3D)
            {
                return (Vecto3D)v1 + (Vecto3D)v2;
            }
            else
            {
                return null;
            }
        }

        //Toán tử *
        public static double operator *(IVecto v1, IVecto v2)
        {
            if (v1 is Vecto2D && v2 is Vecto2D)
            {
                return (Vecto2D)v1 * (Vecto2D)v2;

            }
            else if (v1 is Vecto3D && v2 is Vecto3D)
            {
                return (Vecto3D)v1 * (Vecto3D)v2;

            }
            else
            {
                return 0;
            }
        }
        public double Module();
    }
}
