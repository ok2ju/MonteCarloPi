using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool IsPointInCircle(double R, double x, double y)
        {
            return ((x - R)*(x-R) + (y-R)*(y-R)) <= R * R;
        }

        static void Main(string[] args)
        {
            int radius = 102400;
            int countPoints = 52428800;
            int countPointsInCircle = 0;
            int a = radius * 2;

            double x, y;
            double pi;

            Random random = new Random();

            for (int i = 0; i <= countPoints; i++)
            {
                x = random.NextDouble() * a;
                y = random.NextDouble() * a;

                if (IsPointInCircle(radius,x,y))
                {
                    countPointsInCircle++;
                }
            }

            pi = 4.0 * ((double)countPointsInCircle / (double)countPoints);

            Console.WriteLine(countPointsInCircle);
            Console.WriteLine(pi);
        }
    }
}
