/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Введите число");
string num = Console.ReadLine();

int SumValue(string num)
{
    int sum = 0;
    int value;
    if (Convert.ToInt32(num) >= 0)
    {
        for (int i = 0; i < num.Length; i++)
        {
            value = int.Parse(num[i].ToString());
            sum = sum + value;
        }
    }
    else
    for (int i = 1; i < num.Length; i++)
        {
            value = int.Parse(num[i].ToString());
            sum = sum + value;
        }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе {num} равна {SumValue(num)}");