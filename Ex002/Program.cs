// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void Num(int num)
{
    string Stroka=Convert.ToString(num);
    Console.WriteLine("Третья чифра: "+Stroka[2]);
}
int n;
Console.WriteLine("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
if (n<100)
    Console.WriteLine("Третьей цифры нет");
else {
        Num(n);
     }