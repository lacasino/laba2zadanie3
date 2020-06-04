using System;

namespace laba2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bведiть розмiр масиву");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введiть елементи масиву");
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(num[i]);
            }
            int[] jorik = array1(array);
            for(int i = 0; i < jorik.Length; i++)
            {
                Console.Write(jorik[i] + " ");
            }
        }
        public static int[] array1 (int[] mas)
        {
            int p = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                if(mas[i] % 2 == 0)
                {
                    p++;
                }
            }
            int[] res = new int[p];
            int k = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                if(mas[i]%2 == 0)
                {
                    res[k] = mas[i];
                    k++;
                }
            }
            return res;
        }
    }
}
