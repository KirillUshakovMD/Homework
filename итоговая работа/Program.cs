﻿Console.Clear();
Console.Write("введите количество строк, которые хотите ввести: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
  Console.WriteLine("Введите строку: ");
  array[i] = Console.ReadLine()!;
}
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < n; i++)
{
  if (array[i].Length < 4)
    count++;
}
string[] newArray = new string[count];
count = 0;
for (int i = 0; i < n; i++)
{
  if (array[i].Length < 4)
  {
    newArray[count] = array[i];
    count++;
  }
}
Console.WriteLine($"конечный массив: [{string.Join(", ", newArray)}]");