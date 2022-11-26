//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 100)
{
    Console.WriteLine(" Третьей цифры нет ");
}
if (number >= 100)
{
    if (number < 1000)
    result  = number % 100 % 10;
    
    else
    {
        result = number % 100 / 10;
    }
    Console.Write("Третья цифра этого числа ");
    Console.WriteLine(result);
}