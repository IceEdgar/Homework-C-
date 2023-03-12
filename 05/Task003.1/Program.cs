Console.Clear();
int num = InputNumber("Введите длинну массива ", "Ошибка ввода данных!");
int[] array = new int[num];
FillArray(array, num);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {FindDifference(array, num)}");



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


void FillArray(int[] collection, int i)
{
    int index = 0;
    while (index < i)
    {
        try
        {
            Console.Write("Введите число массива -");
            array[index] = Convert.ToInt32(Console.ReadLine());
            index++;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}


int FindDifference(int[] arr, int length)
{
    int min = arr[0];
    int max = arr[0];
    int dif = 0;
    for (int i = 1; i < length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else
        {
            if (arr[i] < min) min = arr[i];
        }
    }
    dif = max - min;
    return dif;
}