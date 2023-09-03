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

// Взаимодействие с пользователем через консоль. Просим ввести данные.
Write("Введите значения: ");
string[] string_Array1 = GetArrayFromString(ReadLine());
WriteLine();

// Сохраняем количество элементов.
int amountElement = GetAmountElement(string_Array1);

// Инициализируем новый массив и выводим все данные через консоль.
string[] string_Array2 = GetNewArrayFromArray(string_Array1, amountElement);
Write("Новый массив: " + String.Join(", ", string_Array2));


// Метод чтения данных вводимых пользователем из терминала.
string[] GetArrayFromString(string inArray)
{
    string[] array = inArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = (array[i]);
    }
    return result;
}

// Метод который вычесляет количество элементов <= 3 из массива и выдает это количество.
int GetAmountElement(string[] inArray)
{
    int result = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            result++;
        }
        else continue;
    }
    return result;
}


// Метод который получает входной массив и количество элементов для размера нового массива,
// на основе этих данных создает новый массив с элементами которые <= 3.
string[] GetNewArrayFromArray(string[] inArray, int amountElement)
{
    string[] result = new string[amountElement];
    int index = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            result[index] = inArray[i];
            index++;
        }
        else continue;
    }
    return result;
}