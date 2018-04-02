using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstones
{
    public class Program
    {
        static int gemstones(string[] arr)
        {
            var numRocks = arr.Length;
            var numGems = 0;
            var elements = new Dictionary<char, int>();
            for (int i = 0; i < numRocks; i++)
            {
                var s = removeDuplicates(arr[i]);

                for (int j = 0; j < s.Length; j++)
                {
                    char c = s[j];
                    if (elements.ContainsKey(c))
                    {
                        elements[c] += 1;
                    }
                    else
                    {
                        elements.Add(c, 1);
                    }
                }

            }

            numGems = elements.Count(x => x.Value == numRocks);
            return numGems;
        }

        private static string removeDuplicates(string s)
        {
            var lst = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (lst.Contains(s[i]))
                {
                    continue;
                }
                else
                {
                    lst.Add(s[i]);
                }
            }
            return String.Join("", lst);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            int result = gemstones(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

/*
 *John has collected various rocks. Each rock has various minerals embeded in it. Each type of mineral is designated by a lowercase letter in the range ascii[a-z]. There may be multiple occurrences of a mineral in a rock. A mineral is called a gemstone if it occurs at least once in each of the rocks in John's collection.

Given a list of minerals embedded in each of John's rocks, display the number of types of gemstones he has in his collection.

Input Format

The first line consists of an integer n, the number of rocks. 
Each of the next n lines contains a string where each letter represents an occurence of a mineral in the current rock.

Constraints

1 <= n <= 100 
1 <= length of each composition  <= 100
Each composition consists of only lower-case Latin letters ('a'-'z').

Output Format

Print the number of types of gemstones in John's collection. If there are none, print 0.

Sample Input

3
abcdde
baccd
eeabg
Sample Output

2
Explanation

Only a and b are gemstones. They are the only types that occur in every rock.
 *
 *
 */
