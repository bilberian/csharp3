// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    string num = number.ToString();
    if(num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("yes");
    }
    else 
    {
        Console.WriteLine("no");
    }
}
else
{
    Console.WriteLine("введено некорректное число");
}