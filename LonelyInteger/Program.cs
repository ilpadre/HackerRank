using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        static int lonelyinteger(int[] a)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dict.ContainsKey(a[i]))
                {
                    dict[a[i]]++;
                }
                else
                {
                    dict.Add(a[i], 1);

                }
            }
            return dict.Where(x => x.Value == 1).Select(y=>y.Key).FirstOrDefault();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = lonelyinteger(a);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

/*
 * You will be given an array of integers. All of the integers except one occur twice. That one is unique in the array.

Given an array of integers, find and print the unique element.

Input Format

The first line contains a single integer, , denoting the number of integers in the array. 
The second line contains  space-separated integers describing the respective values in .

Constraints

It is guaranteed that  is an odd number and that there is one unique element.
, where .
Output Format

Print the unique integer in the array.

Sample Input 0

1
1
Sample Output 0

1
Explanation 0

There is only one element in the array, thus it is unique.

Sample Input 1

3
1 1 2
Sample Output 1

2
Explanation 1

We have two 's, and  is unique.

Sample Input 2

5
0 0 1 2 1
Sample Output 2

2
Explanation 2

We have two 's, two 's, and one .  is unique.
 */
