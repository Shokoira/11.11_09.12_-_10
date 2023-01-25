// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
double[,] FillMas(int Row, int Column)
{
    double[,] Arr=new double[Row, Column];
    for (int i =0; i<Row; i++)
        for (int j =0; j<Column; j++)
            Arr[i,j]=Math.Round(new Random().NextDouble(),2);
    return Arr;
}
void print(double[,] Mas)
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
Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
double[,] Arr=FillMas(a,b);
print (Arr);