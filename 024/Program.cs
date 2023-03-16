// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введи число x: ");
int x=int.Parse(Console.ReadLine());

Console.Write("Введи число y: ");
int y=int.Parse(Console.ReadLine());

if (x>0&&y>0)
{
    Console.WriteLine("Первая четверть плоскости");
}
if(x<0&&y>0)
{
    Console.WriteLine("Вторая четверть плоскости");
}
if (x<0&&y<0)
{
    Console.WriteLine("Третья четверть плоскости");
}
if(x>0&&y<0)
{
    Console.WriteLine("Четвертая четверть плоскости");
}
if(x==0&&y==0)
{
    Console.WriteLine("Координаты не должны равняться 0");
}
