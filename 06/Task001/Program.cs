Console.Clear();
int length = InputLengthMassiv("Введите длинну массива ", "Ошибка ввода данных!");
int[] array = new int[length];
FillArray(array, length);
Console.WriteLine($"[{String.Join(",", array)}]");
int count = 0;
FindPositiv(array);
Console.WriteLine($"Количество элементов > 0 -  {count}");

static int InputLengthMassiv(string message, string errormessage)
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


void FillArray(int[] collection, int i)
{
    int index = 0;
    while (index < i)
    {
        try
        {
            Console.Write("Введите число массива ");
            array[index] = Convert.ToInt32(Console.ReadLine());
            index++;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}


int FindPositiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}