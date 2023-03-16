// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число: ");

int N=int.Parse(Console.ReadLine());

if (N%7==0 && N%23==0)
{
    Console.WriteLine($"Число {N} кратно числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {N} не кратно 7 и 23");
}