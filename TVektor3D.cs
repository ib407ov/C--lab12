using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TVektor3D : TVektor2D
    {
        public double Z { get; set; }
        public double Z1 { get; set; }

        public TVektor3D(double x, double y, double x1, double y1, double z, double z1):base(x,y,x1,y1)
        {
            Z1 = z1;
            Z = z;
        }

        public double[] lenght3D()
        {
            double[] arr = new double[2];
            arr = lenght();
            arr[0] += Math.Abs(Math.Sqrt(Math.Pow(Z1, 2)));
            arr[1] += Math.Abs(Math.Sqrt(Math.Pow(Z, 2)));
            //arr[0] = Math.Abs(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)));
            //arr[1] = Math.Abs(Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2) + Math.Pow(Z1, 2)));
            return arr;
        }
    }
}
