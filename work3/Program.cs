// Задача №38. Программа, которая задает массив случайных вещественных чисел и находит разницу между максимальным и минимальным элементов массива

Random rnd = new Random();
int[] d = new int[10];
int max = 0, min = 100;
for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}

for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
Console.WriteLine();
Console.WriteLine("Максимальный элемент массива:  " + max);
Console.WriteLine("Минимальный элемент массива:  " + min);
Console.WriteLine("Разница между максимальным и минимальным:  " + (max - min));


