using System;
using static System.Console;
// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
//Первоначальный массив можно вывести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// **Примеры:**
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> [ ]

string[] CreateArrayOf3Characters(string[] array)   //Метод для создания массива из строк, 
{                                                   //длина которых меньше или равна 3 символа.
    int sizeResultArray = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            sizeResultArray++;

    string[] resultArray = new string[sizeResultArray];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    return resultArray;
}



