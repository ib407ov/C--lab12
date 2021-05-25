using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TVektor2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double X1 { get; set; }
        public double Y1 { get; set; }

        public TVektor2D(double x)
        {
            X = x;
            Y = 0;
        }

  
        public TVektor2D(TVektor2D v)
        {
            this.X = v.X;
            this.Y = v.Y;
        }

        public TVektor2D(double x1, double y1, double x, double y)
        {
            Y1 = x;
            X1 = x1;
            X = x;
            Y = y;
        }

        public double[] lenght()
        {
            double[] res = new double[2];
            res [0] = Math.Sqrt(Math.Pow(X,2) + Math.Pow(Y,2));
            res [1] = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));

            return res;
        }

        public double[] normalizationVektors()
        {
            double[] arr = new double[4];
            double z = (X * X + Y * Y + X1 * X1 + Y1 * Y1);
            arr[0] = X / z;
            arr[1] = Y / z;
            arr[2] = X1 / z;
            arr[3] = Y1 / z;

            return arr;
        }

        public double[] compresion()
        {
            double[] arr = new double[2];
            arr[0] = Math.Abs(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(X1, 2)));
            arr[1] = Math.Abs(Math.Sqrt(Math.Pow(Y, 2) + Math.Pow(Y1, 2))); 
            
            return arr;
        }
    }
}
