/*Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
12345 -> 5 */

int count = 0;
void DigitCount(int number) 
{
    if (number == 0)
    {
        return;
    }
    count++;
    DigitCount(number/10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
DigitCount(number);
Console.Write($"Количество цифр в числе: {count}");