// Задайте двумерный массив. Найдите сумму элементов, находящихся по диагонали с индексами
//(0,0);(1,1) и т.д
//Задайте двумерный массив, найдите элементы,у которых оба индекса четные и замените эти элементы на их квадраты
// Задайте двумерный массив m на n, каждый элемент которого находится по формуле: Amn = m+n

//Метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();

    //буфферные переменные строки и столбца
    int i = 0; int j = 0;

    //создаем массив
    int[,] outArray = new int[countRow, countColumn];

    //цикл заполнения массива сначала по столбцам, потом по строчкам
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSintezator.Next(0, 9);
            j++;
        }

        i++;
    }
    //возвращаем значение
    return outArray;
}
ConsoleColor[] col = new ConsoleColor[] {ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};
//Модифицированный метод печати
void PrintColorTwoDimArray(int[,] inputArray)
{

    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 15)];
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;
    }
    //Скидываем настройку цвета консоли
    //Console.ResetColor();
}


int CalcDiagTwoDimArr(int[,] inputArray)
{
    int outSumDiagonal = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i == j)
                outSumDiagonal += inputArray[i, j];

            j++;
        }
        i++;
    }
    return outSumDiagonal;
}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);
int sum = CalcDiagTwoDimArr(twoDimArray);
Console.WriteLine(sum);
