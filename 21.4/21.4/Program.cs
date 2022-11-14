using System;


namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int m = 5, n = 3;
            int[,] myArray = new int[n, m];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(30);
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] newArray = new int[m, n];
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i,j] = myArray[j, i];
                    Console.Write(newArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
