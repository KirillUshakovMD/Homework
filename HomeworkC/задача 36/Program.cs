void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
}
int SumNechet(int[] array)
{
  int result = 0;
  for (int i = 1; i < array.Length; i=i+2)
  {
    result += array[i];
  }
return result;
}
Console.Clear();
Console.WriteLine("vvedite chislo elementov massiva ");
int n = int.Parse(Console.ReadLine()!);
int[]array=new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ",array)}]");
SumNechet(array);
Console.WriteLine(SumNechet(array));