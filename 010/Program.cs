// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Console.WriteLine("Введите число: ");
int a=int.Parse(Console.ReadLine());
int y=a%100;
Console.WriteLine($"Последняя цифра: {y}");

