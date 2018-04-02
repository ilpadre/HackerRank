using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fact(n));
            Console.ReadLine();
        }

        private static BigInteger fact(int num)
        {
            if (num > 0)
                return (BigInteger)(num * fact(num - 1));
            return (BigInteger)(1);
        }
    }
}
