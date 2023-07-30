//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = GenerateRandomArray(5, -100, 100);

        Console.WriteLine("Массив: " + FormatArray(array));

        double difference = FindDifference(array);

        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
    

    static double[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.NextDouble() * (maxValue - minValue) + minValue;
        }

        return array;
    }

    static string FormatArray(double[] array)
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

    static double FindDifference(double[] array)
    {
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max - min;
    }


// используется метод GenerateRandomArray(), чтобы сгенерировать случайный массив вещественных чисел заданного размера size,
// с минимальным значением minValue и максимальным значением maxValue. Метод FormatArray() используется для форматирования массива
// в строку. Метод FindDifference() используется для нахождения разницы между максимальным и минимальным элементами массива.

// сначала генерируется случайный массив с помощью GenerateRandomArray(), затем выводится на экран с помощью FormatArray(). 
// Затем вызывается метод FindDifference() для нахождения разницы между максимальным и минимальным элементами массива, и эта 
// разница выводится на экран.    