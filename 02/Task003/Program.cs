int ReadInt()
{
    int number;
    while (true)
    {
        Console.Write("Введите число от 1 до 7: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int Week(int num)
{
    if (num > 0 && num < 8)
    {
        if (num == 7 || num == 6) Console.Write($"Под цифрой {num} -Ура! Выходной");

        else Console.Write($"Под цифрой {num} - Пора на работу");
    }
    else Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");

    return num;
}

int dayNumber = ReadInt();
Console.WriteLine(Week(dayNumber));