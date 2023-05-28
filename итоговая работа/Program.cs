Console.Clear();
Console.Write("введите количество строк, которые хотите ввести: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
  Console.WriteLine("Введите строку: ");
  array[i] = Console.ReadLine()!;
}

Console.WriteLine($"начальный массиы: [{string.Join(", ", array)}]");

string [] newArray=new string [n];
for (int i = 0; i < n; i++)
{
  int m = array[i].Length;
  if (m<4)
  newArray[i]=array[i];

// Console.WriteLine(m);
}
Console.WriteLine($"конечный массив: [{string.Join(", ", newArray)}]");





