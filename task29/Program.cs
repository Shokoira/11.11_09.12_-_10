// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] EightMas(int a)
{
    int[] Arr=new int[a];
    for (int i =0; i<a; i++)
        Arr[i]=new Random().Next(0,50);
    return Arr;
}
void print(int[] Mas)
{
    for (int i =0; i<Mas.Length; i++)
        Console.Write ($"{Mas[i]} ");
}
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int[] Arr=EightMas(a);
print (Arr);