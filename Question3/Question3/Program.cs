using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will populate two arrays and then add them together");

            Random rand = new Random();

            int[,] arrayA = new int[3,3];
            

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = rand.Next(-10, 10);
                }
            }

            Console.WriteLine("\nArray A:");
            Display(arrayA);


            int[,] arrayB = new int[3, 3];

            for (int i = 0; i < arrayB.GetLength(0); i++)
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    arrayB[i, j] = rand.Next(-10, 10);
                }
            }

            Console.WriteLine("\nArray B:");
            Display(arrayB);


            
            int[,] arrayC = new int[3, 3];

            for (int i =0; i < arrayC.GetLength(0); i++)
            {
                for (int j =0; j < arrayC.GetLength(1); j++)
                {
                    arrayC[i,j] = arrayA[i,j] + arrayB[i,j] ;
                }   
            }
            Console.WriteLine("\nArray C:");
            Display(arrayC);


            Console.ReadLine();


        }


        public static void Display(int[,] array2)
        {

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
