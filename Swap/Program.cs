//void Swap(int x, int y)//Передача по значентю (Value)
//{
  //  int t=x;
    //x=y;
    //y=t;

//}

void Swap(ref int x,ref int y)//Передача по значентю (referecne) ref- модификатор аргументов
{
    int t=x;
    x=y;
    y=t;

}
void Calculator(int a,int b,out int sum,out int sub)
{
    sum=a+b;
    sub=a-b;
}

//int u,r=0,o=0;
//u=r+o;

int a=4;
int b=5;
int s=0,sb=0;
Calculator(a,b,out s,out sb);


System.Console.WriteLine($"a={a} b={b}");
//Классический обмен
Swap(ref a,ref b);
Console.WriteLine($"a={a} b={b}");




























//Хитрый обменя

//a=a+b;
//b=a-b;
//a=a-b;