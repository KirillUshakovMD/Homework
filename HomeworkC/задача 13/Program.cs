Console.Clear();
Console.Write("введите число ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
  Console.WriteLine("третьей цифры нет ");
else 
{
  if(n>999)
  {
    while (n>999)
    n=n/10;
  }
Console.WriteLine($"третья цифра {n%10} ");
}

