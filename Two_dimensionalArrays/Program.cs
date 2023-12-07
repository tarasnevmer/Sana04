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

Console.WriteLine("Матриця: ");
PrintMatrix.printMatrix(matrix);

Console.WriteLine($"\nКількість додатніх елементів: {MatrixOperations.CountPositiveElements(matrix)}\n");
Console.WriteLine($"Максимальне число, яке зустрічається більше одного разу: {MatrixOperations.FindMaxRepeatingNumber(matrix)}\n");
Console.WriteLine($"Кількість рядків без нульових елементів: {MatrixOperations.CountRowsWithoutZero(matrix)}\n");
Console.WriteLine($"Кількість стовпців із хоча б одним нульовим елементом: {MatrixOperations.CountColumnsWithZero(matrix)}\n");
Console.WriteLine($"Номер рядка з найдовшою серією однакових елементів: {MatrixOperations.FindRowWithLongestSeries(matrix)}\n");
Console.WriteLine($"Добуток елементів в рядках без від’ємних елементів: {MatrixOperations.ProductOfRowsWithoutNegative(matrix)}\n");
Console.WriteLine($"Максимум серед сум елементів діагоналей, паралельних головній діагоналі: {MatrixOperations.MaxSumInDiagonals(matrix)}\n");
Console.WriteLine($"Сума елементів в стовпцях без від’ємних елементів: {MatrixOperations.SumOfColumnsWithoutNegative(matrix)}\n");
Console.WriteLine($"Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі: {MatrixOperations.MinSumOfAbsoluteDiagonals(matrix)}\n");
Console.WriteLine($"Сума елементів в стовпцях із хоча б одним від’ємним елементом: {MatrixOperations.SumOfColumnsWithNegative(matrix)}\n");

int[,] transposedMatrix = MatrixOperations.TransposeMatrix(matrix);
Console.WriteLine("Транспонована матриця:");
PrintMatrix.printMatrix(transposedMatrix);
