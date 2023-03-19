Console.Clear();
int rows = InputNumber("Введите количество строк массива ", "Ошибка ввода данных!");
int columns = InputNumber("Введите количество столбцов массива ", "Ошибка ввода данных!");
int indexRow = InputNumber("Введите номер строки нужного числа ", "Ошибка ввода данных!");
int indexColumn = InputNumber("Введите номер столбца нужного числа ", "Ошибка ввода данных!");
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("  - Исходный массив - ");
PrintArray(array);
FindNumberArray(array, indexRow, indexColumn);


static int InputNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(10, 99));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  " + array[i, j]);
        }
        Console.WriteLine("");
    }
}

void FindNumberArray(int[,] array, int x, int y)
{
    x = x - 1;
    y = y - 1;
    if (x > 0 && x < array.GetLength(0) - 1 && y > 0 && y < array.GetLength(1) - 1)
        Console.WriteLine($"Элемент массива с номером позиции ({x + 1}, {y + 1}) -> {array[x, y]}");
    else Console.WriteLine("Такого числа в массиве нет");
}