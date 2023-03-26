void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (99 - 10) + 10, 2);
}
double MAX(double[] array)
{
  double max = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
      max = array[i];
  }
  return max;
}
double MIN(double[] array)
{
  double min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
      min = array[i];
  }
  return min;
}
double[] array = new double[5];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
MAX(array);
MIN(array);
double result = Math.Round(MAX(array) - MIN(array),2);
// Console.WriteLine(MAX(array));
// Console.WriteLine(MIN(array));
Console.WriteLine($"{result}, {MAX(array)}, {MIN(array)}");

