Console.Write("Ведите число - ");
int number;
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.Write($"{number} - данное число чётное!");
else
    Console.Write($"{number}- данное число нечётное!");