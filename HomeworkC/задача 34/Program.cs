﻿void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
int CountChet(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 == 0)
      count += 1;
    }
    return count;
}
Console.Clear();
Console.WriteLine("vvedite chislo elementov ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
CountChet(array);
Console.WriteLine(CountChet(array));