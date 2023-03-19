Console.Clear();
Console.WriteLine("введите пятизначное число ");
int n = int.Parse(Console.ReadLine()!);
while (n < 9999 || n > 100000)
{
  Console.WriteLine("ошибка, введите пятизначное число ");
  n = int.Parse(Console.ReadLine()!);
}
string n1 = n.ToString();
if (n1[0] == n1[4] && n1[1] == n1[3])
  Console.WriteLine("palindrom");
else
{
  Console.WriteLine("ne palindrom");
}