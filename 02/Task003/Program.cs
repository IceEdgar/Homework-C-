

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
int index = number.ToString().Length;

if (index < 3) Console.WriteLine("НЕТ ТРЕТЬЕЙ ЦИФРЫ");
else 
{
    int result=0;
while (number>999)
   {
        number = number / 10;
   }
result=(number%10);  
Console.WriteLine($"Третья цифра - {result}");
}