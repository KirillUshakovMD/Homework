Console.Clear();
Console.Write("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine()!);
  while (n<100 || n> 999)
  {
  Console.WriteLine("введите трехзначное число ");
  n = int.Parse(Console.ReadLine()!);
  }
int n1 = n / 10 % 10;
Console.WriteLine($"{n1}");