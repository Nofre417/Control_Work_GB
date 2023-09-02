/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
        длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
        либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
        лучше обойтись исключительно массивами.

Примеры:
        [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
        [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
        [“Russia”, “Denmark”, “Kazan”] → []
*/



using System;
using static System.Console;

Clear();

Write("Введите значения: ");
string[] string_Array1 = GetArrayFromString(ReadLine());

WriteLine("Вывод: " + String.Join(" ", string_Array1));

string[] GetArrayFromString(string string_Array1)
{
    string[] array = string_Array1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[array.Length];
    for(int i = 0; i <result.Length; i++) 
    {
        result[i] = (array[i]);
    }
    return result;
}