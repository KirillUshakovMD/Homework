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
int[,] Multiply(int[,] firstmatrix, int[,] secondmatrix)
{
  int[,] mult = new int[firstmatrix.GetLength(0), firstmatrix.GetLength(1)];
  for (int i = 0; i < firstmatrix.GetLength(0); i++)
  {
    for (int j = 0; j < firstmatrix.GetLength(1); j++)
      mult[i, j] = firstmatrix[i, j] * secondmatrix[i, j];
  }
  return mult;

}

Console.Write("Введите размер матрицы ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] firstmatrix = new int[size[0], size[1]];
int[,] secondmatrix = new int[size[0], size[1]];
InputMatrix(firstmatrix);
InputMatrix(secondmatrix);
PrintMatrix(firstmatrix);
Console.WriteLine();
PrintMatrix(secondmatrix);
Console.WriteLine();
PrintMatrix(Multiply(firstmatrix, secondmatrix));