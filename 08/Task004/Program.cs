Console.Clear();
int x = InputNumber("Введите размер x трехмерного массива ", "Ошибка ввода данных!");
int y = InputNumber("Введите размер y трехмерного массива ", "Ошибка ввода данных!");
int z = InputNumber("Введите размер z трехмерного массива ", "Ошибка ввода данных!");
Console.WriteLine();
int[,,] array = new int[x, y, z];
FillArray(array);
PrintArray(array);

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


void FillArray(int[,,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int a = 0; a < tempArray.GetLength(0); a++)
    {
        tempArray[a] = new Random().Next(10, 99);
        number = tempArray[a];
        if (a >= 1)
        {
            for (int b = 0; b < a; b++)
            {
                while (tempArray[a] == tempArray[b])
                {
                    tempArray[a] = new Random().Next(10, 99);
                    b = 0;
                    number = tempArray[a];
                }
                number = tempArray[a];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = tempArray[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент массива - {array[i, j, k]} с интексом ({i},{j},{k}) ");
            }
        }
    }
}