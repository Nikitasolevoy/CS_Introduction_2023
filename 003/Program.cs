// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них

int a,b;
string? s;

System.Console.Write("Введите первое число:");

s=Console.ReadLine();
a=Convert.ToInt32(s);

System.Console.Write("Введите второе число:");

s=Console.ReadLine();
b=Convert.ToInt32(s);


if (a>b)
    System.Console.WriteLine($"{a} больше {b}");
if (a<b)
    System.Console.WriteLine($"{a} меньше {b}");
if (a==b)
    System.Console.WriteLine($"{a} равно {b}");