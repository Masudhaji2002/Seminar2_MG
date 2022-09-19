//Zadacha 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int numberthree = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(numberthree);
Console.WriteLine("вторая цифра ==> "+ number[1]);

//Zadacha 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbertext = Convert.ToString(number);
if (numbertext.Length > 2)
{
    Console.WriteLine("третья цифра --> " + numbertext[2]);
}
 else
 {
     Console.WriteLine("третьей цифры нет");
 }

//Zadachya 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
void NumberTheWeek (int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine(number +"==>да");
    }
    else if (number<1 || number > 7)
    {
        Console.WriteLine("Это не день недели");
    }
    else Console.WriteLine(number +"==>нет");
}
NumberTheWeek(number);
