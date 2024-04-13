// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class ReverseArray
{
    // Метод для вывода элементов массива с конца через рекурсию
    public static void PrintReverse(int[] array, int index)
    {
        if (index < 0) // Условие остановки рекурсии
        {
            return;
        }
        
        Console.Write(array[index] + " "); // Вывод текущего элемента
        PrintReverse(array, index - 1); // Рекурсивный вызов с индексом на единицу меньше
    }

    public static void Main()
    {
        int[] array = {1, 2, 3, 4, 5}; // Произвольный массив
        PrintReverse(array, array.Length - 1); // Вызываем метод с последним индексом массива
    }
}
