using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_DS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                
            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", res));
            Console.ReadLine();
        }

        static int[] reverseArray(int[] a)
        {
            var b = a.ToList();
            b.Reverse();
            return b.ToArray();
        }

    }
}

//
// An array is a type of data structure that stores elements of the same type in a contiguous block of memory. In an array, , of size , each memory location has some unique index,  (where ), that can be referenced as  (you may also see it written as ).
//
//Given an array, A , of  integers, print each element in reverse order as a single line of space-separated integers.
//
//Note: If you've already solved our C++ domain's Arrays Introduction challenge, you may want to skip this.
//
//Input Format
//
//The first line contains an integer, N (the number of integers in A). 
//The second line contains N space-separated integers describing A.
//
//Constraints
//
//    1 <= N <= 10^3
//
//    1 <= Ai <= 10^4, where Ai is the ith integer in A
//
//Output Format
//
//Print all N integers in A in reverse order as a single line of space-separated integers.
//
//Sample Input 0
//
//4
//1 4 3 2
//Sample Output 0
//
//2 3 4 1
// 

