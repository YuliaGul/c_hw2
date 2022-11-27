//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberL = number;
int length = 0;
while (numberL >0)
{
    numberL = numberL / 10;
    length ++;
}
if (length < 3)
{
  Console.WriteLine(" Третьей цифры нет ");
}
else
  {
    while (length != 3)
    {
      number = number/10;
      length --;
    }
    number = number%10;
    Console.Write("Третья цифра этого числа ");
    Console.WriteLine(number);
  }
