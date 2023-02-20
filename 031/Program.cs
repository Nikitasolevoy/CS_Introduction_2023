// Вывести на экран кубы чисел от 1 до N
int i=1;
Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine());
Console.WriteLine("Число"+"\t"+"Куб");
for (i=1; i<=N; i++)
{
    Console.WriteLine(i+"\t"+i*i*i);
}

