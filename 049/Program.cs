// В Указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом

int[] a=new int[6];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(6,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int max=a[0];
for(int i=1;i<a.Length;i++)
    if (a[i]>max)
        max=a[i];



System.Console.WriteLine(max);