using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArrays
{
    public class MatrixOperations
    {
        public static int CountPositiveElements(int[,] matrix)
        {
            int count = 0;

            foreach (int element in matrix)
            {
                if (element > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int FindMaxRepeatingNumber(int[,] matrix)
        {
            int maxRepeatingNumber = -1;
            int maxRepeatingCount = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int currentNumber = matrix[i, j];
                    int currentCount = 0;

                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        for (int l = 0; l < matrix.GetLength(1); l++)
                        {
                            if (matrix[k, l] == currentNumber)
                            {
                                currentCount++;
                            }
                        }
                    }

                    if (currentCount > maxRepeatingCount)
                    {
                        maxRepeatingCount = currentCount;
                        maxRepeatingNumber = currentNumber;
                    }
                }
            }

            return maxRepeatingNumber;
        }

        public static int CountRowsWithoutZero(int[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasZero = false;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }

                if (!hasZero)
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountColumnsWithZero(int[,] matrix)
        {
            int count = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasZero = false;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }

                if (hasZero)
                {
                    count++;
                }
            }

            return count;
        }

        public static int FindRowWithLongestSeries(int[,] matrix)
        {
            int longestSeriesRow = 0;
            int maxLength = 0;
            int currentLength = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[i, j - 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            longestSeriesRow = i;
                        }
                        currentLength = 1;
                    }
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestSeriesRow = i;
                }

                currentLength = 1;
            }

            return longestSeriesRow + 1;
        }

        public static int ProductOfRowsWithoutNegative(int[,] matrix)
        {
            int product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasNegative = false;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (!hasNegative)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        product *= matrix[i, j];
                    }
                }
            }

            return product;
        }

        public static int MaxSumInDiagonals(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int k = 1 - matrix.GetLength(0); k < matrix.GetLength(1); k++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int j = i + k;
                    if (j >= 0 && j < matrix.GetLength(1))
                    {
                        sum += matrix[i, j];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }

        public static int SumOfColumnsWithoutNegative(int[,] matrix)
        {
            int sum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasNegative = false;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (!hasNegative)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public static int MinSumOfAbsoluteDiagonals(int[,] matrix)
        {
            int minSum = int.MaxValue;

            for (int k = -matrix.GetLength(1) + 1; k < matrix.GetLength(0); k++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int j = i - k;
                    if (j >= 0 && j < matrix.GetLength(1))
                    {
                        sum += Math.Abs(matrix[i, j]);
                    }
                }

                if (sum < minSum)
                {
                    minSum = sum;
                }
            }

            return minSum;
        }

        public static int SumOfColumnsWithNegative(int[,] matrix)
        {
            int sum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasNegative = false;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] transposedMatrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }
    }
}
