﻿// // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами

Console.Clear();

string[] array1 = new string[4] {"1234", "2567", "-2", "computer science"};
string[] array2 = new string[array1.Length];
int count = 0;

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
        {
            Console.Write($"{inArray[i]}\t ");
        }
        Console.WriteLine();
    
}
SecondArray(array1, array2);
PrintArray(array2);