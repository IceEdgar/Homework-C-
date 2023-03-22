Console.Clear();
int index = InputNumber("Введите разрядность квадратного массив ", "Ошибка ввода данных!");
int[,] array = new int[index, index];
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

void FillArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    int n = array.GetLength(0);
    while (temp <= n * n)
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < n - 1) j++;
        else if (i < j && i + j >= n - 1) i++;
        else if (i >= j && i + j > n - 1) j--;
        else i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}