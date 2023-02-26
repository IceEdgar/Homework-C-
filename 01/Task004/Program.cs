Console.Write("Ведите число - ");
int number;
number = Convert.ToInt32(Console.ReadLine());

while (number > 0)
{
    if (number % 2 == 0)
    {
        Console.Write($"{number}, ");
        number = (number - 2);
    }
    else
        number = number - 1;
}
