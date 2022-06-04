using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linear arrays
            int[] arr1 = new int[5];
            arr1[0] = 10;
            arr1[1] = 40;
            arr1[2] = 30;

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };

            /*for(int i=0; i < 6; i++)
            {
                Console.WriteLine(arr2[i]);
            }*/

            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }
            int[] arr3 = new int[] { 10, 20, 30, 40, 50 };
            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }

            //Multi Dimension Array
            int[,] m_arr1 = new int[2, 3] { { 1, 2, 3 }, { 11, 22, 33 } };
            int[,] m_arr2 = new int[,] { { 1, 2, 3 }, { 11, 22, 33 } };
            int[,] m_arr3 = new int[2, 3];
            m_arr3[0, 0] = 1;
            m_arr3[0, 1] = 2;

            // Jagged Array - Also called Array of arrays -> diffrent type of arrays in one array
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 10, 20 };
            arr[2] = new int[4] { 11, 22, 33,44 };
            foreach (int[] ar in arr)
            {
                foreach (int item in ar)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                  
            }

            //Sorting
            int[] u_arr = new int[] { 7, 3, 5, 1, 9, 2 };
            int temp;
            for(int i=0; i < u_arr.Length; i++)
            {
                for(int j = 0; j < u_arr.Length - 1; j++)
                {
                    if(u_arr[j] > u_arr[j+1])
                    {
                        temp = u_arr[j];
                        u_arr[j] = u_arr[j + 1];
                        u_arr[j + 1] = temp;
                    }
                }
            }
            foreach(int item in u_arr)
            {
                Console.WriteLine(item);
            }

            //Matrix program
            int[,] ar = new int[3, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 }, { 11, 22, 33, 44 } };
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(ar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
