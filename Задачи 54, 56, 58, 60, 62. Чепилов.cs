Console.Clear();
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
// НАЧАЛО КОДА ЗАДАЧИ 54

int[,] New2DArray()
{
    Console.Write($"количество строк -> ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"количество колонок -> ");
    int coll = Convert.ToInt32(Console.ReadLine());

    int[,] new2DArray = new int[rows, coll];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coll; j++) new2DArray[i, j] = new Random().Next(0, 99);
    return new2DArray;
}

void PechatNew2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"строка {i + 1} -> ");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} | ");
        Console.WriteLine();  // следующая строка
    }
    Console.WriteLine(); // отступаем от массива 1 строчку
}

int[,] Sortirovka (int[,] SortArr)
{
    int max = 0;
    for (int i = 0; i < SortArr.GetLength(0); i++)
        for (int j = 0; j < SortArr.GetLength(1); j++)
        {
            for (int newColl = 0; newColl < SortArr.GetLength(1) - 1; newColl++)
            {
                if (SortArr[i, newColl] < SortArr[i, newColl + 1])
                {
                    max = SortArr[i, newColl + 1];
                    SortArr[i, newColl + 1] = SortArr[i, newColl];
                    SortArr[i, newColl] = max;
                }
            }

        }
    return SortArr;
}

int[,] userArray = New2DArray();
Console.WriteLine("наш массив:");
Console.WriteLine();
PechatNew2DArray(userArray);

// собстна, цель задачи:
int[,] sortiruem = Sortirovka (userArray);
Console.WriteLine("тот же массив, но сортированный от максимума к минимуму построчно:");
PechatNew2DArray(sortiruem);

// КОНЕЦ КОДА ЗАДАЧИ 54


//----------------------------------------------------------------
//----------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
*/
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// НАЧАЛО КОДА ЗАДАЧИ 56
/*
int[,] New2DArray_Prjamougolnij()
{
    Console.Write($"количество строк -> ");
    int rows = Convert.ToInt32(Console.ReadLine());
    while (rows <= 0)
    {
        Console.WriteLine("ну ты чего)) как это - строки впуклые штоль?)). давай заново:");
        rows = Convert.ToInt32(Console.ReadLine());
    }


    Console.Write($"количество колонок -> ");
    int coll = Convert.ToInt32(Console.ReadLine());
    while (coll == rows)
    {
        Console.WriteLine("таак, забыл сказать - массив д/б прямоугольный. и количеств колонок тоже НЕ впуклое)). давай заново: ");
        rows = Convert.ToInt32(Console.ReadLine());
    }

    int[,] new2DArray = new int[rows, coll];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coll; j++) new2DArray[i, j] = new Random().Next(0, 10);
    return new2DArray;
}

void PechatNew2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"строка {i + 1} -> ");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} | ");
        Console.WriteLine();  // следующая строка
    }
    Console.WriteLine(); // отступаем от массива 1 строчку
}

int SummOfElemsInRow(int[,] arrayToSumm, int i)
{
    int sumInRow = arrayToSumm[i, 0];
    for (int j = 1; j < arrayToSumm.GetLength(1); j++)
    {
        sumInRow = sumInRow + arrayToSumm[i, j];
    }
    return sumInRow;
}

void MinimumVStroke(int[,] arr)
{
    int minSumRow = 0;
    int sumRow = SummOfElemsInRow(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumm = SummOfElemsInRow(arr, i);
        if (sumRow > tempSumm)
        {
            sumRow = tempSumm;
            minSumRow = i;
        }
    }
    Console.WriteLine($"строка {minSumRow + 1} имеет минимальную сумму элементов, равную {sumRow}."); // +1 к строке типа умный))
}


int[,] array = New2DArray_Prjamougolnij();
Console.WriteLine("наш массив:");
PechatNew2DArray(array);
MinimumVStroke(array);
*/

// КОНЕЦ КОДА ЗАДАЧИ 56
//----------------------------------------------------------------
//----------------------------------------------------------------

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
/*
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
// НАЧАЛО КОДА ЗАДАЧИ 58
/*
int DlinaM() // задаём метод, чтобы потом сделать квадратную матрицу
{
    Console.Write("значит, у нас будут 2 квадраные матрицы. а сторона будет длиной -> ");
    int dlina = Convert.ToInt32(Console.ReadLine());
    while (dlina <= 0)
    {
        Console.Write("опять впуклый массив захотел?)) давай по новой ->");
        dlina = Convert.ToInt32(Console.ReadLine());
    }
    return dlina;
}

int[,] SquareM(int dlina)
{
    int[,] new2dArray = new int[dlina, dlina];

    for (int i = 0; i < dlina; i++)
        for (int j = 0; j < dlina; j++)
            new2dArray[i, j] = new Random().Next(1, 7);

    return new2dArray;
}

void Pechat2M(int[,] arrayToPrint1, int[,] arrayToPrint2)
{
    Console.WriteLine("вот первая матрица:");
    for (int i = 0; i < arrayToPrint1.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint1.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("вот вторая:");
    for (int i = 0; i < arrayToPrint2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint2.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] M1xM2(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = 0;
            for (int t = 0; t < array1.GetLength(1); t++)
            {
                temp = temp + array1[i, t] * array2[t, j];
            }
            result[i, j] = temp;
        }
    }
    return result;
}

void PrintResultOf_M1xM2(int[,] m1_x_m2)
{
    Console.WriteLine("собстна, ниже результат перемножения элементов 2ух матриц на одинаковых позициях^");
    for (int i = 0; i < m1_x_m2.GetLength(0); i++)
    {
        for (int j = 0; j < m1_x_m2.GetLength(1); j++)
        {
            Console.Write($"{m1_x_m2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int dlina_ = DlinaM();
int[,] arr1 = SquareM(dlina_);
int[,] arr2 = SquareM(dlina_);
Pechat2M(arr1, arr2);
int[,] arrayMulti = M1xM2(arr1, arr2);
PrintResultOf_M1xM2(arrayMulti);
*/
// КОНЕЦ КОДА ЗАДАЧИ 58
//----------------------------------------------------------------
//----------------------------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
// НАЧАЛО КОДА ЗАДАЧИ 60
/*
int [] Koord3D ()
{
    Console.Write($"наш икс -> ");
    int x = Convert.ToInt32(Console.ReadLine());
    while (x <= 0)
    {
        Console.Write($"икс д/б больше нуля. заново -> ");
        x = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write($"наш игрэк -> ");
    int y = Convert.ToInt32(Console.ReadLine());
    while (y <= 0)
    {
        Console.Write($"игрэк д/б больше нуля. заново -> ");
        y = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write($"наш зэд -> ");
    int z = Convert.ToInt32(Console.ReadLine());
    while (z <= 0)
    {
        Console.Write($"зэд д/б больше нуля. заново -> ");
        z = Convert.ToInt32(Console.ReadLine());
    }

    int [] userData = new int [3];
    userData[0] = x;
    userData[1] = y;
    userData[2] = z;

    return userData;
}

int [,,] New3DArray (int [] koord)
{
    int [,,] new3DArray = new int [koord[0], koord[1], koord[2]];
    for (int i = 0; i < koord[0]; i++)
        for (int j = 0; j < koord[1]; j++)
            for (int t = 0; t < koord[2]; t++)
                new3DArray[i,j,t] = Convert.ToInt32(new Random().Next(10,100));
    return new3DArray;
}

void Pechat3DArray (int [,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(2); t++) Console.Write($"{array[i,j,t]}({i},{j},{t}) ");
            Console.WriteLine();
        }
    }
}

int [,,] userArr = New3DArray(Koord3D ());
Pechat3DArray(userArr);
*/
// КОНЕЦ КОДА ЗАДАЧИ 60
//----------------------------------------------------------------
//----------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// НАЧАЛО КОДА ЗАДАЧИ 62

/*
double [,] NewSpiral2DArray (int razmer) // int не подходит
{
    double [,] spiral = new double [razmer, razmer];
    
    int current = 1;
    int i = 0;
    int j = 0;
    
    while (current <= razmer*razmer)
    {
        spiral[i,j] = current;
        current++;
        if (i <= j + 1 && i + j < razmer - 1) j++;
        else if (i < j && i + j >= razmer - 1) i++;
        else if (i >= j && i + j > razmer - 1) j--;
        else i--;
        
    }
// фуух...
    return spiral;
}


void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j].ToString().PadLeft(2, '0')} "); // https://www.cyberforum.ru/csharp-beginners/thread688875.html спасибо им))
        }
        Console.WriteLine();
    }
}

double [,] userSpiralArr = NewSpiral2DArray(4); // можно через отдельный метод с что-то типа "вы ввели значение меньше нуля и всё такое". но 4, так 4))
PrintArray(userSpiralArr);
*/

// КОНЕЦ КОДА ЗАДАЧИ 62
//----------------------------------------------------------------
//----------------------------------------------------------------