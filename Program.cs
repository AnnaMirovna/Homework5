//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.                                                  

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count += 1;

    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value from 100 to 999: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a mux possible value from 100 to 999: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = EvenNumbers(myArray);
Console.Write("The number of even numbers in the array is " + result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfOddindex(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a mux possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOfOddindex(myArray);
Console.Write("The sum of the elements standing in odd positions is " + result);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2);
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double DifferenceOfValues(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
            max = array[i];
        else
            min = array[i];
    }
    return max - min;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a mux possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double result = DifferenceOfValues(myArray);
Console.Write("The difference between the maximum and minimum array value is " + result);
*/