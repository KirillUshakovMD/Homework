﻿Console.Clear();
Console.Write("Введите 1 число: ");

int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");

int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
  Console.WriteLine(a);
else if (b>a)
  Console.WriteLine(b);