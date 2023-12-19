using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v15
{
    public class Task1
    {
        public void PrintArray(double[] array)
        {
            foreach (var element in array)
            {
                // выводим элеименты массива до второго знака после запятой
                Console.Write($"{element:F2} ");
            }
            Console.WriteLine();
        }

        // метод подсчета отрицательных элементов
        public int CountNegativeElements(double[] array)
        {
            if(array == null ||  array.Length == 0) {  return 0; }
            int count = 0;
            foreach (var element in array)
            {
                if (element < 0)
                {
                    count++;
                }
            }
            return count;
        }

        // метод сложения модулей после минимального по модулю элемента
        public double SumOfModulesAfterMinElement(double[] array)
        {
            if (array == null || array.Length == 0) { return 0; }
            // Находим минимальный по модулю элемент
            double minElement = array[0];
            foreach (var element in array)
            {
                if (Math.Abs(element) < Math.Abs(minElement))
                {
                    minElement = element;
                }
            }

            // Суммируем модули элементов после минимального по модулю элемента
            double sum = 0;
            bool foundMinElement = false;
            foreach (var element in array)
            {
                if (foundMinElement)
                {
                    sum += Math.Abs(element);
                }

                if (element == minElement)
                {
                    foundMinElement = true;
                }
            }

            return sum;
        }

        // метод замены отрицательных чисел их квадратами и сортировка массива
        public double[] ProcessArray(double[] array)
        {
            if (array == null || array.Length == 0) { return null; }
            // Заменяем отрицательные элементы их квадратами
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = array[i] * array[i];
                }
            }

            // Упорядочиваем массив по возрастанию
            Array.Sort(array);

            return array;
        }
    }
}
