﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write($"{array[i]}");
}   
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 ) count++;
}
Console.WriteLine($"-> {count}");