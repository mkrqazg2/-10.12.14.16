/* //Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int[,]arr= new int[3,10];
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 99);
            Console.Write(arr[i, j] + " ");
        }
    Console.WriteLine();
    }
 for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = arr.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (arr[i, k] > arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
        Console.WriteLine();
    }
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,3}",arr[i, j]);
        }
        Console.WriteLine();
    } */

/* //Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,]myArr = new int[4, 3];                                                                   
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i,j]=new Random().Next(0,4);
        Console.Write($" {myArr[i,j]}");
    }
    Console.WriteLine();
}
int[] res = new int[myArr.GetLength(0)];  //массив для хранения сумм строк
int summ1 = 0;
for (int i = 0; i <myArr.GetLength(0) ; i++)
    {
    for (int j = 0; j < myArr.GetLength(1); j++)
        {
            summ1 += myArr[i, j];   //суммируем элементы строки////////////
        }
            res[i] = summ1; //пишем сумму в массив
            summ1 = 0; //обнуляем переменную
    }
int min = 0;    //индекс строки с минимальной суммой
for (int j = 1; j <myArr.GetLength(0) ; j++)
{
    if (res[j] < res[min])   //если есть строка с суммой меньше, то пишем в max её индекс
        min = j;
}
Console.WriteLine("Номер строки с минимальной суммой элементов: "+min); */

// Задача 61: Найти произведение двух матриц.
Console.WriteLine(" Первая матрица: ");
int[,]arr= new int[3,3];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(2, 5);
        Console.Write($" {arr[i,j]}");
    }
Console.WriteLine();
}
Console.WriteLine(" Вторая матрица: ");
int[,]myarr= new int[arr.GetLength(0),arr.GetLength(1)];
for (int i = 0; i < myarr.GetLength(0); i++)
{
    for (int j = 0; j < myarr.GetLength(1); j++)
    {
        myarr[i, j] = new Random().Next(2, 5);
        Console.Write($" {myarr[i,j]}");
    }
Console.WriteLine();
}
Console.WriteLine(" Произведение матриц: ");
int[,]resMass = new int[arr.GetLength(0),arr.GetLength(1)];
for (int n = 0; n < myarr.GetLength(0); n++)
{
    for (int m = 0; m < myarr.GetLength(1); m++)
    {
        for (int k = 0; k < myarr.GetLength(1); k++)
            resMass[n, m] += arr[n, k]*myarr[k, m];
            Console.Write($" {resMass[n,m]}");
    }
Console.WriteLine();
}
        


