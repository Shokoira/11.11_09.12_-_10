// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void find (int[,] Arr)
{
    int Row=Arr.GetLength(0);
    int Column=Arr.GetLength(1);
    for (int i =0; i<Row; i++)
    {
        for (int j =0; j<Column; j++)
        {
            for (int f=0; f<Column-j-1; f++)
                if (Arr[i,f]<Arr[i,f+1])
                    (Arr[i,f],Arr[i,f+1])=(Arr[i,f+1],Arr[i,f]);
        }
    }
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
find (Arr);
Console.WriteLine();
print (Arr);
