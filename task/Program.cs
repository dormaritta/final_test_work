/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо 
равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

string[] array = new string[4] { "floppa", "flip", "flop", ":-)" }; //задан массив из 4-х эл-в
string[] SortedArray = new string[array.Length]; //объявляется отсортированный массив

void ArraySorting(string[] array, string[] SortedArray) //метод сортировки массива
{
    int count = 0; //счетчик для прохода по элементам массива

    for (int i = 0; i < array.Length; i++) //поиск элементов меньше 3-х символов
    {
        if (array[i].Length <= 3) 
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array) //вывод 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ArraySorting(array, SortedArray);
PrintArray(SortedArray);