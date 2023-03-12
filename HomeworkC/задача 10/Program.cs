Console.Clear();
Console.Write("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine()!);
int n1 = n / 10 % 10;
Console.WriteLine($"{n1}");