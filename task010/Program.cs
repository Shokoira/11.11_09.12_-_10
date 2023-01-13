// See https://aka.ms/new-console-template for more information
int MaxNum(int a)
{
    int b=0;
    Console.WriteLine(a);
    while (a>0)
    {
        int c=a%10;
        if (c>b)
            b=c;
        a=a/10;
    }
    return b;
}




Console.WriteLine(MaxNum(new Random().Next(10,100)));
