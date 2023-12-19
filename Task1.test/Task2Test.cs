using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v15.test
{
    public class Task2Test
    {
        [Fact]
        public void IsFindFirstNonNegativeColumnValid()
        {
            Task2 task = new Task2();
            int[,] matrix = { { -4, 0, -9, 8 }, { 8, -3, 2, 0 }, { 9, 6, -10, 9 } };

            Assert.Equal(GetValidValue(matrix), task.FindFirstNonNegativeColumn(matrix));
        }

        [Fact]
        public void IsFindFirstNonNegativeColumnValid1()
        {
            Task2 task = new Task2();
            int[,] matrix1 = { { 4, 0, -9, 8 }, { 8, 3, 2, 0 }, { 9, 6, 10, -9 } };

            
            Assert.Equal(GetValidValue(matrix1), task.FindFirstNonNegativeColumn(matrix1));
        }

        [Fact]
        public void IsFindFirstNonNegativeColumnValid2()
        {
            Task2 task = new Task2();
            int[,] matrix2 = { { 4, 0, 9, 8 }, { 8, 3, 2, 0 }, { 9, 6, 10, 9 } };

            Assert.Equal(GetValidValue(matrix2), task.FindFirstNonNegativeColumn(matrix2));
        }

        [Fact]
        public void IsSortMatrixRowsValid()
        {
            Task2 task = new Task2();
            int[,] matrix = { { -4, 0, -9, 8 }, { 8, -3, 2, 0 }, { 9, 6, -10, 9 } };
            Assert.Equal(matrix, task.ReturnMatrix(matrix));

        }

        int GetValidValue(int[,] matrix)
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

            return -1;
        }
    }
}
