﻿// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Точка А. Введите координату Х точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка А. Введите координату Y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка А. Введите координату Z точки А: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка B. Введите координату Х точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка B. Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка B. Введите координату Z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)), 2);
Console.WriteLine($"Расстояние между точками А и B равно: {distance}");