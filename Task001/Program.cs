﻿/*
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result >=1)
{
break;
}
else
{
Console.WriteLine("Ввели не корректное число. Повторите ввод");
}
}

return result;
}

string GetNaturalNambers(int number)
{
if (number == 1)
return "1";
return GetNaturalNambers(number-1)+" "+ number.ToString();


}

int number = GetNumber("Введите число: ");
Console.WriteLine(GetNaturalNambers(number));