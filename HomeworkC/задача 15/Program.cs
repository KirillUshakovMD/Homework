Console.Clear();
Console.WriteLine("Введите число от 1 до 7 ");
int n = int.Parse(Console.ReadLine()!);
while (n > 7 || n < 1)
{
  Console.WriteLine("Введите другую цифру ");
  n = int.Parse(Console.ReadLine()!);
}
if (n == 6 || n == 7)
{
  Console.WriteLine("Выходной ");
}
else
{
  Console.WriteLine("Будний ");
}