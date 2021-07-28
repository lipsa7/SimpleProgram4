using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.sumOfSquares(n));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int sumOfSquares(int n)
        {
            if (n <= 0)
            {
                return -1;
            }
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }
            return sum;
        }
    }
}
