int number;
while (true)
{
    Console.Write("Введите пятизначное число - ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}
int index = number.ToString().Length;
int index1 = number / 10000;
int index2 = (number % 10000) / 1000;
int index3 = (number % 100) / 10;
int index4 = number % 10;


if (index == 5)
{
    if ((index1 == index4) && (index2 == index3))
        Console.Write($"Число {number} -  палиндром");
    else Console.Write($"Число {number} - не палиндром");
}
else Console.Write("Вы ввели не пятизначное число");
