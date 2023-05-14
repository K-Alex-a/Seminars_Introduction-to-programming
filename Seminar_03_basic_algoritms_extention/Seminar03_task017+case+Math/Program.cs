// Про кейсы:

Console.Write("Введите число: ");           // запрос на ввод числа
int num = Convert.ToInt32(Console.ReadLine());    // прием числа под переменную num

switch (num)                                // подаем переменную на вход
{
    case 1:                                 // если ввели 1, то ->
    {
        Console.WriteLine("один");          // выводим на печать "один"
        break;                              // обрыв строки
    }
    case 2:                                 // если ввели 2, то ->
    {
        Console.WriteLine("два");           // выводим на печать "два"
        break;                              // обрыв строки
    }
    case 3:                                 // если ввели 3, то ->
    {
        Console.WriteLine("три");           // выводим на печать "три"
        break;                              // обрыв строки
    }
    default: 
    {
        Console.WriteLine("Нет данных");    // выводим на печать ...
        break;                              // обрыв строки
    }
}


// ******MATH._*******
// Console.Write("Ведите число: " );
// double num = double.Parse(Console.ReadLine());
// Console.WriteLine(Math.Pow(num,3));              // степнь
// Console.WriteLine(Math.Sqrt(num));               // корень
// Console.WriteLine(Math.Round(num));              // округление
// double num1 = Math.Round(num,3);                 // округление на указааное число
// Console.WriteLine(num1);                         
// Console.WriteLine(Math.Abs(num));                // перевод с отрицательного в положительное