// С клавиатуры вводится два числа. Найти и вывести на экран их сумму.
string? s;
int a,b,sum;
System.Console.Write("Input A ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input B ");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1 Конкатикация (Сливание) строк
System.Console.WriteLine(a+"+"+b.ToString()+"="+Convert.ToString(sum));
//2 Форматированный вывод
System.Console.WriteLine("{0}+{1}={2}",a,b,sum);
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}",a,b,sum); //для дробных чисел
//3 Инетрполяция строк
System.Console.WriteLine($"{a:F2}+{b:E5}={sum:G4}");


//С клавиатуры вводится два числа. Найти и вывести на экран максимальное из них.
int max;
if (a>b)
{
    max=a;
}
else
{
    max=b;
}
System.Console.WriteLine($"max={max}");