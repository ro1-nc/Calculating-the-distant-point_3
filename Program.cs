using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_DistPt_3
{
    class Program
    {
        class DistantPt
        {
            public double[] point1 = new double[3];
            public double[] point2 = new double[3];

            public static double[] Dist_from_start_point(double[] pt1, double[] pt2, double dist)
            {
                double a = pt2[0] - pt1[0];
                double b = pt2[1] - pt1[1];
                double c = pt2[2] - pt1[2];

                double magnitude = Math.Sqrt(a * a + b * b + c * c);
                //if(dist>magnitude)
                //{
                //    Console.WriteLine("Your point doesnt lies on line");
                //    return null;
                //}
                //this is unit vector
                double x = a / magnitude;
                double y = b / magnitude;
                double z = c / magnitude;


                //this is vector ac..assuming pt c in between ac
                double[] vector_ac = new[] { dist * x, dist * y, dist * z };

                double p = vector_ac[0] + pt1[0];
                double q = vector_ac[1] + pt1[1];
                double r = vector_ac[2] + pt1[2];

                return new[] { p, q, r };
            }
        }
        static void Main(string[] args)
        {
            double[] point1 = new double[3] { 1, 0, 0 };
            double[] point2 = new double[3] { 7, 0, 0 };

            Console.WriteLine("Enter co-ordinates of 1st 3D point");

            //for (int i = 0; i < 3; i++)
            //{
            //    point1[i] = Convert.ToDouble(Console.ReadLine());
            //}


            Console.WriteLine("Enter co-ordinates of 2nd 3D point");

            //for (int i = 0; i < 3; i++)
            //{
            //    point2[i] = Convert.ToDouble(Console.ReadLine());
            //}

            Console.WriteLine("Enter distance from start point of 1st 3D point");

            double dist_from_start_point = Convert.ToDouble(Console.ReadLine());

            double[] x = DistantPt.Dist_from_start_point(point1, point2, dist_from_start_point);

            Console.WriteLine("Point from distance of {3} from start point of 1st 3D point is {0},{1},{2}", x[0], x[1], x[2], dist_from_start_point);

            Console.ReadKey();
        }
    }

}
