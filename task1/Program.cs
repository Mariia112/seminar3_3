//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
int number = new Random().Next(10000, 99999);
Console.WriteLine(number);

string str = number.ToString();
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
*/

System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10000 && number <= 99999)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число является палиндромом");
    }
}
else
    System.Console.WriteLine("Число не является пятизначным. Введите корректное число");