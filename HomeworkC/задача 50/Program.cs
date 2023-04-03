void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(0, 50);

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
Console.Write("введите размерность массива ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("введите номер строки ");
int n =int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер столбца ");
int m =int.Parse(Console.ReadLine()!);
if(n>matrix.GetLength(0)||m>matrix.GetLength(1))
{
  Console.WriteLine("такой позиции нет ");
}
else
{
  Console.WriteLine($"{matrix[n-1,m-1]}");
}