/*
Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клаиватуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/

string[] array = new string[4];

array[0] = "hello";
array[1] = "2";
array[2] = "world";
array[3] = ":-)";

Console.Write("[ " + array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " ]  ->  ");

void NewArray(string[] array)
{
    string[] arr = new string[array.Length];

    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        int charStr = array[i].Length;

        if (charStr <= 3)
        {
            arr[i] = array[i];
            Console.Write(arr[i] + " ");
        }
    }
    Console.Write("]");
}

NewArray(array);