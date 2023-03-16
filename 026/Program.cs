// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine());

int a=N/10000;
int b=(N/1000)%10;
int c=(N/10)%10;
int d=N%10;

if(a==d && b==c)
{
    Console.WriteLine($"Число {N} является палинромом");
}
else
{
    Console.WriteLine($"Число {N} не является палинромом");
}
