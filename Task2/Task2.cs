// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length)
    {
        numbers[i] = new Random().Next(-10, 100);
    }
}

int RecognizeOddIndex(int[] numbers, int index)
{
    
}