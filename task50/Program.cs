// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
int[,] FillMas(int Row, int Column,int start, int stop)
{
    int[,] Arr=new int[Row, Column];
    for (int i =0; i<Row; i++)
        for (int j =0; j<Column; j++)
            Arr[i,j]=new Random().Next(start, stop);
    return Arr;
}
void print(int[,] Mas)
{
    int Row=Mas.GetLength(0);
    int Column=Mas.GetLength(1);
    for (int i =0; i<Row; i++)
    {
        for (int j =0; j<Column; j++)
            Console.Write($" {Mas [i,j],6} ");
        Console.WriteLine();
    }

}
void find (int[,] Arr, int c, int k)
{
    int Row=Arr.GetLength(0);
    int Column=Arr.GetLength(1);
    if (c>Row || k>Column)
        Console.WriteLine("ошибка");
    else 
        Console.WriteLine($"{Arr[c-1,k-1]}");
}
Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите начальное значение");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите конечное значение");
int d = Convert.ToInt32(Console.ReadLine());
int[,] Arr=FillMas(a,b,f,d);
print (Arr);
Console.WriteLine("введите строку р1");
int р1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец р2");
int р2 = Convert.ToInt32(Console.ReadLine());
find (Arr,р1,р2);
