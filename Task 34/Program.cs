//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = GenerateRandomArray(4, 100, 999);

        Console.WriteLine("Массив: " + FormatArray(array));

        int evenCount = CountEvenNumbers(array);

        Console.WriteLine("Количество чётных чисел: " + evenCount);
    

    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    static string FormatArray(int[] array)
    {
        string result = "[";

        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];

            if (i != array.Length - 1)
            {
                result += ", ";
            }
        }

        result += "]";

        return result;
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }    



// В этом примере мы используем метод GenerateRandomArray() для генерации случайного массива указанного размера size, 
// с минимальным значением minValue и максимальным значением maxValue. Метод FormatArray() используется для форматирования
// массива в виде строки. Метод CountEvenNumbers() проходит по каждому числу в массиве и увеличивает счетчик count на единицу, если число четное.

// сначала генерируется массив с помощью GenerateRandomArray(), затем выводится на экран. 
// Затем вызывается метод CountEvenNumbers() для подсчета количества четных чисел в массиве и выводится полученное значение на экран    