
// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


public class Task3
{
    public static void Main(string[] args)
    {
        // Входная строка для проверки
        string input = "bш2алашb";

        // Вызов метода для проверки, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(input);

        // Вывод результата
        Console.WriteLine(isPalindrome ? "Да" : "Нет");
    }

    // Метод для проверки, является ли строка палиндромом
    public static bool IsPalindrome(string str)
    {
        // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру
        string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        // Сравнение строки с ее перевернутым вариантом
        return normalized.SequenceEqual(normalized.Reverse());
    }
}

// Метод IsPalindrome выполняет несколько действий:
// Нормализует входную строку str, удаляя все символы, которые не являются буквами или цифрами (используя char.IsLetterOrDigit).
// Приводит нормализованную строку к нижнему регистру (ToLower).
// Проверяет, равна ли нормализованная строка своему перевёрнутому варианту (SequenceEqual(normalized.Reverse())).
// Если строка совпадает со своей перевёрнутой версией, значит, она является палиндромом, и метод возвращает true; иначе возвращает false.