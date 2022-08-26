// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int Num(int num)
{
    int x=num/10;
    x=x%10;
    return x;
}
int n;
int x;
Console.WriteLine("Введите трехзначное число:");
n=Convert.ToInt32(Console.ReadLine());
if (n<100 || n>999)
    Console.WriteLine("Нужно было ввести трехзначное число");
else {
        x=Num(n);
        Console.WriteLine("Вторая цифра вашего числа: " +x);
     }