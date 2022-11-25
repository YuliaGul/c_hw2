Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int index = (number / 10) % 10;
Console.Write("Вторая цифра этого числа ");
Console.WriteLine(index);
