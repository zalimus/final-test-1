// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Пример: ["hello", "2", "world", ":-)"] -> [ "2", ":-)"]



string[] originalArray = new string[] { "hello", "2", "world", ":-)" };


string[] FilteredArray(string[] originalArray)
{
    int count = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] filteredArray = new string[count];
    int index = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            filteredArray[index] = originalArray[i];
            index++;
        }
    }

    return filteredArray;
}
