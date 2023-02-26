

Console.Write("Ведите первое число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второ число - ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.WriteLine($"Максимальное число -> {max}");
Console.WriteLine($"Минимальное число -> {min}");
