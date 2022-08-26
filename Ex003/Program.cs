// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void Num(int num)
{
    int x=num;
    if(x==6 || x==7)
        Console.WriteLine("Этот день выходной");
    else 
        Console.WriteLine("Этот день рабочий");
}
int n;
Console.WriteLine("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
if (n>0&&n<8)
    Num(n);
else Console.WriteLine("В следующий раз введите число от 1 до 7");