// Задача №36. Программа, которая задает одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях.

int[] arr = new int[7];
int k = 0, sum = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 7; i++)
{
    arr[i] = rnd.Next(0, 50);
    Console.Write("{0} ", arr[i]);
}

foreach (int element in arr)
{
    if (element % 2 == 1)
    {
        k++;
        sum += element;
    }
}
Console.WriteLine();
Console.WriteLine("Cумма четных элементов равна {1}", k, sum);