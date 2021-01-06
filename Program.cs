using System;

namespace Line_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] list = new int[] { 9, 0, 1, 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("не отсортированный массив: \n");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
           

            for (int i = 0; i < list.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                int change = list[i];
                list[i] = list[min];
                list[min] = change;
            }

            Console.WriteLine("отсортированный массив: \n");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
