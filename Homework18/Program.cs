//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();

    //буфферные переменные строки и столбца
    int i = 0; int j = 0;

    //создаем массив
    double[,] outArray = new double[countRow, countColumn];

    //цикл заполнения массива сначала по столбцам, потом по строчкам
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSintezator.NextDouble() * 20 - 1;
            outArray[i, j] = Math.Round(outArray[i, j], 2);
            j++;
        }

        i++;
    }
    //возвращаем значение
    return outArray;
}

ConsoleColor[] col = new ConsoleColor[] {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};
//Модифицированный метод печати
void PrintColorTwoDimArray(double[,] inputArray)
{
    //Буфферная переменная
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Выводим конец строки
        //Console.Write("\n");
        //или
        Console.WriteLine();
        i++;
    }
    //Скидываем настройку цвета консоли
    //Console.ResetColor();
}

double[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);

