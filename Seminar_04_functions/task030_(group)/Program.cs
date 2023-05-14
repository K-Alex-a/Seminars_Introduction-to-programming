// Задача 030 (*в группе*):
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// Вариант 1:
int[] ToArray()                                 // создаем метод по сбору рандомного массива со значениями от 0 до 1
{
    int[] array = new int[8];                   // указываем длинну массива 8
    for (int i = 0; i < array.Length; i++)      // пока i меньше длинны массива (23), то делаем ->
    {
        array[i] = new Random().Next(0, 2);     // подбор рандомных значений от 0 до 1
    }
    return array;                               // выводим в результат полученный массив
}

string PrintArray(int[] array)                  // создаем метод для печати массива
{
    string str = "[";                           // первым идет на печать квадратная скобка
    for (int i = 0; i < array.Length; i++)      // пока i меньше длинны массива, то делаем ->
    {
        str += $"{array[i]}, ";                 // добавляем попеременно с запятой строку с массивом
    }
    str += "\b\b]";                             // закрываем квадратную скобку
    return str;                                 // выводим результат
}

Console.WriteLine(PrintArray(ToArray()));      // выводим печать, запуская в методе печати массива, сборку самого массива 



// Вариант 2 (через foreach):
// int[] array = new int[8];
// FillArray(array);
// ShowArray(array);

// void FillArray(int[] arr)
// {
//     foreach (int element in arr)
//     {
//         arr[element] = new Random().Next(0, 2);
//     }
// }
// void ShowArray(int[] arr)
// {
//     foreach (int element in arr)                      // ??? как работает foreach ???
//     {
//         Console.Write($"{element} ");
//     }
// }