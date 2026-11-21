// using System.Collections.Generic;

// // Шаг 3
// try
// {
//     Console.Write("Введите целое число: ");
//     int number = int.Parse(Console.ReadLine());
//     Console.WriteLine($"Число: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }

// Console.WriteLine("Программа продолжает работу");

// try
// {
//     Console.Write("Введите целое число: ");
//     int number = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine(number);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }

// // Шаг 4
// try
// {
//     Console.Write("Делимое: ");
//     int first = int.Parse(Console.ReadLine() ?? "");

//     Console.Write("Делитель: ");
//     int second = int.Parse(Console.ReadLine() ?? "");

//     int result = first / second;
//     Console.WriteLine($"Результат: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Ошибка: число или результат вне диапазона int");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Ошибка: деление на ноль");
// }

// Шаг 5
// void AddScore(List<int> scores, int score)
// {
//     if (score < 0 || score > 100)
//     {
//         throw new ArgumentOutOfRangeException(nameof(score), "Результат должен быть от 0 до 100");
//     }
//     scores.Add(score);
// }

// List<int> testScores = new List<int>();
// try
// {
//  AddScore(testScores, 80);
//  AddScore(testScores, -5);
//  AddScore(testScores, 90);
// }
// catch (ArgumentOutOfRangeException)
// {
//  Console.WriteLine("Ошибка: результат должен быть от 0 до 100");
// }
// Console.WriteLine($"Сохранено результатов: {testScores.Count}");

// void AddScore(List<int> scores, int score)
// {
//     if (score < 0 || score > 100)
//     {
//         throw new ArgumentOutOfRangeException(nameof(score));
//     }
//     scores.Add(score);
// }

// // Шаг 6
// try
// {
//     Console.Write("Введите целое число: ");
//     int number = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine($"Число: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Ошибка: число вне диапазона int");
// }
// finally
// {
//     Console.WriteLine("Попытка ввода завершена");
// }

// Шаг 7
Console.Write("Введите целое число: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Число: {number}");
}
else
{
    Console.WriteLine("Не удалось прочитать целое число");
}

int ReadCount()
{
    while (true)
    {
        Console.Write("Сколько результатов сохранить (0-10): ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int count) && count >= 0 && count <= 10)
        {
            return count;
        }
        Console.WriteLine("Введите целое число от 0 до 10");
    }
}

string input = "abc";
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Принято число: {number}");
}
else
{
    Console.WriteLine("Не удалось прочитать целое число");
}