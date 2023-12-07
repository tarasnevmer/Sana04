using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArrays
{
    public class GenerateMatrix
    {
        public static int [,] generateMatrix(int rows,  int columns, int lowerRange = -10, int upperRange = 10)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    matrix[i,j] = random.Next(lowerRange, upperRange + 1);
                }
            }
            return matrix;
        }
    }
}
