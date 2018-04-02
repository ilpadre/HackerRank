using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstruction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = stringConstruction(s);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        private static int stringConstruction(string s)
        {
            var cost = 0;
            var p = string.Empty;
            var notDone = true;
            var index = 0;
            var temp = s;
            while (index < s.Length)
            {
                var smallestLength = LongestCommonSubstring(temp, p);
                if (smallestLength <= 1)
                {
                    p= p + temp[0];
                    temp = temp.Substring(1, temp.Length-1);
                    cost++;
                    index++;
                }
                else
                {
                    var substr = temp.Substring(0, smallestLength);
                    p = p + substr;
                    index += smallestLength;
                }

            }
            Console.WriteLine(p);
            return cost;
        }

        public static int LongestCommonSubstring(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return 0;

            int[,] num = new int[str1.Length, str2.Length];
            int maxlen = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                        num[i, j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];
                        }
                    }
                }
            }
            return maxlen;
        }

    }
}
