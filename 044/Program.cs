﻿// (Линейный поиск) Определить, присутствует ли в заданном массиве, некоторое число


int[] a=new int[10];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();


//Линейный поиск (Liner search)

int find=5;
int j=0;
while (j<a.Length && a[j]!=find) {
    j++;
    System.Console.WriteLine(j);
}
if (j==a.Length)
    System.Console.WriteLine("No");
else
{
    System.Console.WriteLine($"Element {find} found at index {j}");
}
