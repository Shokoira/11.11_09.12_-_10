// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] EightMas(int a)
{
    double[] Arr=new double[a];
    Random d = new Random();
    for (int i =0; i<a; i++)
        Arr[i]=Math.Round(d.NextDouble()*10,2);
    return Arr;
}
void print(double[] Mas)
{
    for (int i =0; i<Mas.Length; i++)
        Console.Write ($"{Mas[i]} ");
}
double iven(double[] Mas)
{
    double d_Max = Mas[0];
    double d_Min = Mas[0];
    for (int i =0; i<Mas.Length; i++)
       {
        if (Mas[i]>d_Max)
            d_Max=Mas[i];
        if (Mas[i]<d_Min)
            d_Min=Mas[i];    
       }
    Console.WriteLine($"Min: {d_Min}, Max: {d_Max}");
    
    return Math.Round(d_Max-d_Min,2);
}
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
double[] Arr=EightMas(a);
print (Arr);
Console.WriteLine(iven(Arr));