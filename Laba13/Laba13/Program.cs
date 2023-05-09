using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 8, 3, 1, 4 };

        // Переставляем элементы массива с четными индексами
        for (int i = 0; i < arr.Length; i += 2)
        {
            if (i + 1 < arr.Length && arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

            // Возводим элемент в квадрат
            arr[i] = arr[i] * arr[i];
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (int elem in arr)
        {
            Console.Write(elem + " ");
        }
    }
}