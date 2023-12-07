using Two_dimensionalArrays;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть кількість рядків: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введіть кількість стовпців: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введіть нижню межу діапазону: ");
int lowerRange = int.Parse(Console.ReadLine());

Console.Write("Введіть верхню межу діапазону: ");
int upperRange = int.Parse(Console.ReadLine());

int[,] matrix = GenerateMatrix.generateMatrix(N, M, lowerRange, upperRange);

