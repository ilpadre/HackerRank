using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            printArray(rotateArray(a, k));
            Console.WriteLine(rotateLinq(k,a));
            Console.ReadLine();
//            while (true)
//            {
//                Console.WriteLine();
//                displayMenu();
//                var inStr = Console.ReadLine();
//                switch (inStr)
//                {
//                    case "1":
//                        Console.WriteLine();
//                        rotateOnce();
//                        break;
//                    case "2":
//                        Console.WriteLine();
//                        rotateAll();
//                        break;
//                    case "3":
//                        Environment.Exit(0);
//                        break;
//                    default:
//                        Environment.Exit(0);
//                        break;
//                }
//
//            }
        }

        private static void displayMenu()
        {
            Console.WriteLine("1. Rotate once");
            Console.WriteLine("2. Rotate 'Array.Length' times");
            Console.WriteLine("3. Exit program");
            Console.WriteLine();
            Console.Write("Enter a choice (1-3) ");
        }
        private static void rotateOnce()
        {
            Console.WriteLine("Enter two numbers. <array-size> <element-to-begin-rotation>");
            var userInput = Console.ReadLine();
            string[] inputArray = userInput.Split(' ');
            var size = Convert.ToInt32(inputArray[0]);
            var startAt = Convert.ToInt32(inputArray[1]);
            int[] intArray = generateArray(size);

            printArray(intArray);
            int[] rotatedArray = rotateArray(intArray, startAt);
            printArray(rotatedArray);
        }

        private static void rotateAll()
        {
            Console.WriteLine("Enter size of array");
            var userInput = Console.ReadLine();
            var size = Convert.ToInt32(userInput);
            int[] intArray = generateArray(size);

            printArray(intArray);
            for (int i = 1; i <= size; i++)
            {
                int[] rotatedArray = rotateArray(intArray, i);
                printArray(rotatedArray);
            }
        }

        private static int[] generateArray(int size)
        {
            int[] intArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                intArray[i] = i + 1;
            }
            return intArray;
        }

        private static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        private static int[] rotateArray(int[] arr, int startAt)
        {
            int[] rotatedArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                rotatedArray[i] = arr[(startAt  + i) % arr.Length];
            }
            return rotatedArray;
        }

        static string rotateLinq(int rot, int[] arr)
        {
            string left = string.Join(
                " ", arr.Take(rot).ToArray()
            );
            string right = string.Join(
                " ", arr.Skip(rot).ToArray()
            );
            return right + ' ' + left;
        }
    }
}
