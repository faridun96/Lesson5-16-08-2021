using System;

namespace ArrayNApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());  
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min]) 
                min = i; 
            }
            Console.WriteLine("Минимальное значение массива: " + array[min]);
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max]) 
                max = i;
            }
            Console.WriteLine("Максимальное значение массива: " + array[max]);
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {  
                sum+= array[i]; 
            }
            Console.WriteLine("Общая сумма всех элементов массива: " + sum);
            int result = 0;
            int mid = 0;
            for (int i = 0; i < array.Length; i++)
            {  
                result+= array[i]; 
                mid = result/array.Length;
            }
            Console.WriteLine("Среднее арифметическое всех элементов: " + mid);
            for (int i = 0; i <= array.Length; i++)
                if (i % 2 != 0)
            Console.WriteLine("Нечетные значения {0} ", i);
        }
    }
}
