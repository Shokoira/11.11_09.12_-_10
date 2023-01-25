// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    double Res=0;
    for (int i =0; i<Column; i++)
    {
        Res=0;
        for (int j =0; j<Row; j++)
            Res+=Arr[j,i];
        Console.WriteLine(Res/Row);
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