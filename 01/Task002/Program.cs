Console.WriteLine("Ведите три числа - ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB) max = numberB;
if (max < numberС) max = numberС;
Console.WriteLine($"Максимальное число -> {max}");