//      3) Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//         и проверяет, является ли этот день выходным.

Console.Write("Введите цифру дня недели:  ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 6;
int c = 7;
if (a == b || a == c)
    Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Это будний день");