// Задача 58. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];
Random rnd = new Random(); 

Console.WriteLine("Заданная двумерная матрица 1: ");
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine("Заданная двумерная матрица 2: ");
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine($"Произведение двух матриц: ");
MultiplyMatrix(resultMatrix);
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] matrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] FillMatrix(int[,] matrix)
{  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}, ");
        }
        Console.WriteLine();
    }
}
