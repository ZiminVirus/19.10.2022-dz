﻿// Задача 34: Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1)) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");   
}

int NumberEvenElem(int[] array, int sum) 
{
    sum =default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
            sum ++;
    }
    return sum;
}

int[] arr = CreateArrayRndInt(4, 100, 1000);
PrintArray(arr);
int numb = default;
int numberOfEvenElements = NumberEvenElem(arr, numb);
Console.Write ($"->{numberOfEvenElements}");
