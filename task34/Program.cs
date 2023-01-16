// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] EightMas(int a)
{
    int[] Arr=new int[a];
    for (int i =0; i<a; i++)
        Arr[i]=new Random().Next(100,1000);
    return Arr;
}
void print(int[] Mas)
{
    for (int i =0; i<Mas.Length; i++)
        Console.Write ($"{Mas[i]} ");
}
int iven(int[] Mas)
{
    int count = 0;
    for (int i =0; i<Mas.Length; i++)
       {
        if (Mas[i]%2==0)
            count++;
       }
    return count;
}
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
double[] Arr=EightMas(a);
print (Arr);
Console.WriteLine(iven(Arr));