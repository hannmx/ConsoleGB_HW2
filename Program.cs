using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-ое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите 2-ое число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите 3-е число: ");
            int c = int.Parse(Console.ReadLine());
            int max = 0;

            void MaxValue()
            { 
                int[] array = new int[3]{ a, b, c};
                int temp = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                max = array[2];
                return;
            }
            MaxValue();
            Console.WriteLine($"Максимальным значением является {max}");
        }
    }
}
