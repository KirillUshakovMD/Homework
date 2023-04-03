void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(0, 11);

  }
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]}\t");
    Console.WriteLine();
  }
}
void SumStolb(int[,] matrix)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum = sum + matrix[i, j];
    }
  Console.WriteLine($"{sum / matrix.GetLength(0)}");
  }
}
Console.Clear();
Console.Write("Введите размерность массива ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SumStolb(matrix);
