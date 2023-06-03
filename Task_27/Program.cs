// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Вариант 1
// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// int sum = 0;
// for (int i = 0; i < number.Length; i++)
//     sum = sum + Convert.ToInt32(number[i].ToString());
// Console.WriteLine(sum);

//Вариант 2
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;
while (n != 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");
