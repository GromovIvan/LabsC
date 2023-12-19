using System;

namespace lab1v15
{


    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива N: ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                // Создаем массив и заполняем его случайными вещественными числами
                double[] array = new double[N];
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    array[i] = random.NextDouble() * (random.Next(2) == 0 ? -1 : 1); // Генерация случайных вещественных чисел со знаком
                }

                Task1 task1 = new Task1();

                Console.WriteLine("Сгенерированный массив:");
                task1.PrintArray(array);

                // Вычисление количества отрицательных элементов
                Console.WriteLine($"Количество отрицательных элементов: {task1.CountNegativeElements(array)}");

                // Вычисление суммы модулей элементов после минимального по модулю элемента
                Console.WriteLine($"Сумма модулей элементов после минимального по модулю элемента: {task1.SumOfModulesAfterMinElement(array):F2}");

                // замена отрицательных чисел их квадратами и упорядочывание массива
                Console.WriteLine("Измененный и упорядоченный массив:");
                task1.PrintArray(task1.ProcessArray(array));
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Размер массива должен быть положительным целым числом.");
            }

            int rows, cols;

            // просим пользователя ввести верны размеры матрицы, пока их не получим
            do
            {
                Console.WriteLine("Введите размеры прямоугольной матрицы");
                int.TryParse(Console.ReadLine(), out rows);
                int.TryParse(Console.ReadLine(), out cols);
                if(rows > cols)
                {
                    Console.WriteLine("Введите размеры наоборот");
                }
            } while(rows > cols);

            Task2 task2 = new Task2();

            int[,] matrix = GenerateRandomMatrix(rows, cols, -10, 10);
            // матрица до изменения
            task2.PrintMatrix(matrix);
            // сортировка матрицы
            task2.SortMatrixRows(matrix);
            // матрица после изменения
            task2.PrintMatrix(matrix);
            // вывод номера первого столбца без отрицательных элементов
            int colNumber = task2.FindFirstNonNegativeColumn(matrix);
            if(colNumber == -1)
            {
                Console.WriteLine($"\nВ матрице нет столбцов без отрицательных элементов");
            } else
            {
                Console.WriteLine($"\nНомер первого столбца без отрицательных элементов: {colNumber + 1}");
            }

        }

        // метод генерации матрицы
        static int[,] GenerateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

    }
}
