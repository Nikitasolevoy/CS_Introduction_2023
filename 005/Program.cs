// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
string? s; // Я так понял, что Parse тоже самое что и string?))

Console.Write("Введите первое число: ");

s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.Write("Введите второе число: ");

s=Console.ReadLine();
b=Convert.ToInt32(s);

Console.Write("Введите третье число: ");

s=Console.ReadLine();
c=Convert.ToInt32(s);


//Console.Write("Введите первое число: ");
//int a=int.Parse(Console.ReadLine());

//Console.Write("Введите второе число: ");
//int b=int.Parse(Console.ReadLine());

//Console.Write("Введите третье число: ");
//int c=int.Parse(Console.ReadLine());
    
if (a<b && c<b)
{
    Console.WriteLine($"Максимальное число: {b}");
}
else if (a<c)
{
    Console.WriteLine($"Максимальное число: {c}");
}
else
{
    Console.WriteLine($"Максимальное число: {a}");
}
