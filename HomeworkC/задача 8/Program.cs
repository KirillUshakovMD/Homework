Console.Clear();

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int i = 0;
for (i=0;i<n; i+=2);
  Console.WriteLine($"{i}");