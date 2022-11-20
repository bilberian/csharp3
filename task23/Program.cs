// Задача 23
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));


for (int i = 1; i <= number; i++)
{
    //Console.Write(Math.Pow(i, 3) + " ");
    //без Math.Pow:
    Console.Write(i * i * i + " ");
};

 //или с while:
 Console.WriteLine();
 int j = 1;
 while (j <= number)
 {
    Console.Write(Math.Pow(j, 3) + " ");
    j++;
 }