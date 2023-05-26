string f(int a, int b)
{
  if (a == 0)
    return $"{b} ";
  return f(a - 1, b+ 1);
}


Console.Clear();
Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));