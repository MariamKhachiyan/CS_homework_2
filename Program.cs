/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* 
Console.WriteLine("Enter three digit number ");
int num = Convert.ToInt32(Console.ReadLine());


 if (num < 100 || num >= 1000)
{
    Console.WriteLine("Enter correct number!These number isn't three digit");
    
}
else 
{
    int SecondDigit= num / 10 % 10;
    Console.WriteLine($"Second digit {SecondDigit}");
}


 */


 /* Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */
/*  
 int num = new Random().Next(10,40000);
 
 if (num < 100 )
 {
    Console.WriteLine("Third digit isn't exist");
 }
 else 
{
    int X = num;
    while (X / 1000 >=1)
    {
        X = (X - X % 10) / 10;
    }
    int ThirdDigit = X % 10;
    Console.WriteLine($"Third digit of number  {num}: {ThirdDigit} ");
}
 */

/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот
 день выходным.
6 -> да
7 -> да
1 -> нет */
/* 


int num = new Random().Next(1,8);

if (num == 1) Console.WriteLine("Today is Monday, Weekday");
if (num == 2) Console.WriteLine("Today is Tuesday, Weekday");
if (num == 3) Console.WriteLine("Today is Wednesnday, Weekday");
if (num == 4) Console.WriteLine("Today is Thursday, Weekday");
if (num == 5) Console.WriteLine("Today is Friday, Weekday");
if (num == 6) Console.WriteLine("Today is Saturday - WEEKEND!!!");
if (num == 7) Console.WriteLine("Today is Sunday - WEEKEND!!!");


 */
