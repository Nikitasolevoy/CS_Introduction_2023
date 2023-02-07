// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.Write("Введите число в диапазоне от 10 до 99: ");
int a=int.Parse(Console.ReadLine());
int c1=a/10;
int c2=a%10;
int max=c1;
if(c2>max) max=c2;
{
    System.Console.WriteLine($"Цифра {max} больше");
}
if (c2==c1)
{
    System.Console.WriteLine("Цифры равны!");
}

