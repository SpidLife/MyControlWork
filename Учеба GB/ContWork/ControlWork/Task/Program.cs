﻿// В данной задаче не указана информация о том, важен ли размер нового массива.
// Найдем размер нового который будет равен количеству string удовлетворяющим нашему условию.

// Solution Берем 3 тестовых массива.

string[] array = { "123", "hello", "3456", "Tesla", "Stick", "X-D", "V1;", "Nope", "Front", "10101" };
string[] array2 = { "1234", "Hello", "Find", "Rolex", "Dog" };
string[] array3 = { "1234", "hello", "barabym", "Volvo", "Moon", "Light", "Cucumder", "9401" };

string[] FindCountStringLessThanFourChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    if (arr.Length == 0)
    {
        System.Console.WriteLine("This array is empty");
    }
    else
    {
        System.Console.Write("The new array where string length is <= 3 eqials: ");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write($"{arr[i]} ");
        }
    }
}

System.Console.WriteLine("Test 1");
string[] newArray = FindCountStringLessThanFourChar(array);
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine("Test 2");
string[] newArray2 = FindCountStringLessThanFourChar(array2);
PrintArray(newArray2);
System.Console.WriteLine();
System.Console.WriteLine("Test 3");
string[] newArray3 = FindCountStringLessThanFourChar(array3);
PrintArray(newArray3);