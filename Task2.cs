using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v15
{

    public class Task2
    {
        public int[,] ReturnMatrix(int[,] matrix)
        {
            SortMatrixRows(matrix);
            return matrix;
        }

        // метод поиска первого столбца без отрицательных элементов
        public int FindFirstNonNegativeColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                bool hasNegativeElement = false;

                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegativeElement = true;
                        break;
                    }
                }

                if (!hasNegativeElement)
                {
                    return j;
                }
            }

            // Если все столбцы содержат хотя бы один отрицательный элемент
            return -1;
        }

        // метод вывода матрицы на печать
        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // метод сортировки матрицы
        public void SortMatrixRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - 1; j++)
                {
                    // подсчитываем сколько одинаковых эелементов в каждой строке
                    int countJ = CountEqualElements(matrix, j);
                    int countJPlus1 = CountEqualElements(matrix, j + 1);

                    // меняем строки местами, если они не на своих
                    if (countJ > countJPlus1)
                    {
                        SwapRows(matrix, j, j + 1);
                    }
                }
            }
        }

        // метод по подсчету одинкаовых элементов в строке
        private int CountEqualElements(int[,] matrix, int rowIndex)
        {
            int columns = matrix.GetLength(1);
            int count = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = i + 1; j < columns; j++)
                {
                    if (matrix[rowIndex, i] == matrix[rowIndex, j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        // метод для перемещения друг между другом строк
        private void SwapRows(int[,] matrix, int rowIndex1, int rowIndex2)
        {
            int columns = matrix.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                int temp = matrix[rowIndex1, i];
                matrix[rowIndex1, i] = matrix[rowIndex2, i];
                matrix[rowIndex2, i] = temp;
            }
        }

        
    }

}
