using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppendAndDelete
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tests
//            testAppend();
//            testDelete();
//            testIndexOfIdentical();

            // The real thing
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(convertStoTinK(s,t,k));

            // Keep the window open
            Console.ReadLine();
        }

        private static string convertStoTinK(string s, string t, int k)
        {
            int numOpps = 0;
            string newS = s;
            string oldT = t;
            string answer = "No";

            int index = findIndexOfIdentical(s, t);
            int tempIndex = index >=0? index:0;
            int charsToDelete = s.Length - index;
            for (int i = 0; i < charsToDelete; i++)
            {
                newS = delete(newS);
                numOpps++;
            }
            for (int i = 0; i < charsToDelete; i++)
            {
                newS = append(newS, oldT[tempIndex++]);
                numOpps++;
                if (newS.Equals(oldT))
                {
                    answer = "Yes";
                    break;
                }
                if (numOpps > k)
                {
                    break;
                }
            }
            return answer;
        }

        private static int findIndexOfIdentical(string s, string t)
        {
            int index = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    index = i;
                    break;
                }

            }
            return index;
        }

        private static string append(string s, char c)
        {
            return s + c;
        }

        private static string delete(string s)
        {
            if (s == string.Empty)
                return s;
            return s.Substring(0, s.Length - 1);
        }

        private static void  testAppend()
        {
            string s1 = "Hello";
            string s2 = string.Empty;
            char c1 = 'C';

            if (append(s1, c1) == "HelloC")
            {
                Console.WriteLine("Append Test 1: Passed");
            }
            else
            {
                Console.WriteLine("Append Test 1: Failed");

            }

            if (append(s2, c1) == "C")
            {
                Console.WriteLine("Append Test 2: Passed");
            }
            else
            {
                Console.WriteLine("Append Test 2: Failed");

            }



        }

        private static void testDelete()
        {
            string s1 = "Hello";
            string s2 = string.Empty;
            if (delete(s1) == "Hell")
            {
                Console.WriteLine("Delete Test 1: Passed");
            }
            else
            {
                Console.WriteLine("Delete Test 1: Failed");

            }
            if (delete(s2) == string.Empty)
            {
                Console.WriteLine("Delete Test 2: Passed");
            }
            else
            {
                Console.WriteLine("Delete Test 2: Failed");

            }
        }

        private static void testIndexOfIdentical()
        {
            string s1 = "hackerhappy";
            string t1 = "hackerrank";
            string s2 = "aba";
            string t2 = "aba";

            if (findIndexOfIdentical(s1, t1) == 6 )
            {
                Console.WriteLine("FindIndex Test 1: Passed");
            }
            else
            {
                Console.WriteLine("FindIndex Test 1: Failed");

            }
            if (findIndexOfIdentical(s2, t2) == -1)
            {
                Console.WriteLine("FindIndex Test 2: Passed");
            }
            else
            {
                Console.WriteLine("FindIndex Test 2: Failed");

            }
        }
    }
}
