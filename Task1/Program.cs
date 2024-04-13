
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

class Program
{
    // Метод для рекурсивного вывода чисел от M до N
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " "); // Вывод текущего числа
            PrintNumbers(m + 1, n); // Рекурсивный вызов для следующего числа
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите M:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNumbers(m, n);
    }
}
