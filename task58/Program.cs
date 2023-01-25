// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] find (int[,] Arr1, int[,] Arr2)
{
    int Row=Arr1.GetLength(0);
    int Column=Arr1.GetLength(1);
    int[,] NewArr=new int[Row, Column];
    if (Column != Arr2.GetLength(0)) return NewArr;
    else if (Column == Arr2.GetLength(0)) NewArr=new int [Row,Row];
    for (int i =0; i<Row; i++)
    {
        for (int j =0; j<Row; j++)
            for (int h =0; h<Column; h++)
                NewArr [i,j]+=Arr1[i,h]*Arr2[h,j];
    }
    return NewArr;
}

Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите начальное значение");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите конечное значение");
int d = Convert.ToInt32(Console.ReadLine());
int[,] Arr1=FillMas(a,b,f,d);
print (Arr1);
Console.WriteLine("введите количество строк");
int aa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int bb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите начальное значение");
int ff = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите конечное значение");
int dd = Convert.ToInt32(Console.ReadLine());
int[,] Arr2=FillMas(aa,bb,ff,dd);
print (Arr2);
int [,] Arr3=find (Arr1, Arr2);
print (Arr3);
