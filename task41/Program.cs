/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3  */

Console.Write("Введите количество чисел (M): ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
for(int i = 0; i < M; i++)
{
    Console.Write($"Введите {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
string arr = string.Join(", ", array);
Console.Write(arr);
Console.WriteLine();

int count = 0;
for (int i = 0; i < M; i++)
{
    if (array[i] > 0)
    {
    count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Нет чисел больше нуля");
}
else 
{
Console.WriteLine($"Чисел больше нуля: {count}");
}
