//       2)Напишите программу, которая принимает на вход трёхзначное число
//         и на выходе показывает вторую цифру этого числа.

Console.Write("Введите любое число:  ");
int n = Convert.ToInt32(Console.ReadLine());
string str = n.ToString();
if (n > 99)
    Console.WriteLine(str [2]);
else
    Console.WriteLine("Третьей цифры нет");

