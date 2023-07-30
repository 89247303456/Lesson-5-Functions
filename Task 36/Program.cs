//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = GenerateRandomArray(4, -100, 100);

        Console.WriteLine("Массив: " + FormatArray(array));

        int sum = SumOddIndexedElements(array);

        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    

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

    static int SumOddIndexedElements(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        return sum;
    }    



//В этом примере мы используем метод GenerateRandomArray() для генерации случайного массива
// указанного размера size, с минимальным значением minValue и максимальным значением maxValue. 
//Метод FormatArray() используется для форматирования массива в виде строки. Метод SumOddIndexedElements() 
//находит сумму элементов, стоящих на нечетных позициях, путем прохода по массиву с шагом 2, начиная с индекса 1.

//генерируется массив с помощью GenerateRandomArray(), затем выводится на экран. 
//Затем вызывается метод SumOddIndexedElements() для нахождения суммы элементов на 
//нечетных позициях и выводится полученное значение на экран.    