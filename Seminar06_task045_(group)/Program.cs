// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

// Вариант 1:
Console.Write("Введите колличество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(num);
PrintArray(array);
Console.Write(" -> ");
PrintArray(CopyArray(array));

void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 11);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}