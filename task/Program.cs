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

Console.WriteLine("Введите элементы для сортировки через запятую: ");
string[] array = Console.ReadLine()!.Split(',');

void ArraySorting(string[] massif)
{
    int ElementSize = 4;
    string[] SortedArray = new string[massif.Length];
    var element = string.Empty;

    for (int i = 0; i < massif.Length; i++)
    {
        element = massif[i];
        if (element.Length < ElementSize)
        {
            SortedArray[i] = massif[i];
        }
    }
    Console.WriteLine($"Отсортированный массив: [{string.Join(",", massif)}]");
}