int number;
while (true)
{
    Console.Write("Введите число - ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}
int index = 1;
double kub = 0;

while (index <= number)
{
    kub = Math.Pow(index, 3);
    Console.WriteLine($"Число {kub} - является кубом числа {index}");
    index++;
}