// void InputMatrix(int[, ,] ThreeMatrix)
// {
//   int number = 10;
//   for(int i=0;i<ThreeMatrix.GetLength(0);i++)
//   {
//     for (int j=0;j<ThreeMatrix.GetLength(1); j++)
//     {
//       for(int k=0;k<ThreeMatrix.GetLength(2);k++)
//       ThreeMatrix[i,j,k]=number++;
//     }
//   }
// }
// void PrintMatrix(int [, ,] ThreeMatrix)
// {
//   for(int i=0;i<ThreeMatrix.GetLength(0);i++)
//   {
//     for (int j=0;j<ThreeMatrix.GetLength(1); j++)
//     {
//       for(int k=0;k<ThreeMatrix.GetLength(2);k++)
//       Console.WriteLine($"{ThreeMatrix[i,j,k]}({i},{j},{k})");
//     }
//   }
// }
// Console.Clear();
// Console.Write("введите размер трехмерного массива: ");
// int [] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
// while (size[0]*size[1]*size[2]>90)
// {
//   size=Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
// }
// int [,,] ThreeMatrix=new int [size[0], size[1],size[2]];
// InputMatrix(ThreeMatrix);
// PrintMatrix(ThreeMatrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}
PrintArray(array);