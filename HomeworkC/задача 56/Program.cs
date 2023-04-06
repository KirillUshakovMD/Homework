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
int Sort(int[,] matrix)
{
int minRow=0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    minRow=minRow+matrix[0,i];
  }
  
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int sum=0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum=matrix[i,j]+sum;
    }
    if(minRow>sum)
    minRow=sum;
  }
  return minRow;
}
Console.Clear();
Console.Write("Введите размер матрицы ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while(size[0]==size[1])
{
  Console.Write("введите другой размер ");
  size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результат {Sort(matrix)}");
//PrintMatrix(matrix);