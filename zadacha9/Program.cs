using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 3 / (9 * (Math.Pow(n, 2)) + 3 * n - 2);


            }
            Console.WriteLine("Sum = {0}", s);
            Console.ReadLine();
        }
    }
}
