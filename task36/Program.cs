// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] EightMas(int a)
{
    int[] Arr=new int[a];
    for (int i =0; i<a; i++)
        Arr[i]=new Random().Next(1,100);  
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
    for (int i =0; i<Mas.Length; i=i+2)
      count=count+Mas[i];
    return count;
}
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int[] Arr=EightMas(a);
print (Arr);
Console.WriteLine();
Console.WriteLine(iven(Arr));