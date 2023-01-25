// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
int[] find (int[,] Arr)
{
    int Row=Arr.GetLength(0);
    int Column=Arr.GetLength(1);
    int[] NewArr=new int[Row];
    for (int i =0; i<Row; i++)
    {
        for (int j =0; j<Column; j++)
            NewArr [i]+=Arr[i,j];
    }
    return NewArr;
}
void FindMin (int[] Arr)
{
int MinNum=0;
for (int i=0; i<Arr.Length; i++)
    if (Arr[i]<Arr[MinNum])
        MinNum=i;
Console.WriteLine($"сумма {Arr [MinNum]}, Строка {MinNum+1}");
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
FindMin (find (Arr));
