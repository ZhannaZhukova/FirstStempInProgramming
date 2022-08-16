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
//Метод печатает двумерныймассив
void PrintTwoDimArray(int[,] inputArray)
{
    //Буфферная переменная
    int i = 0; int j = 0;

    //цикл заполнения массива сначала по столбцам, потом по строчкам
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Выводим конец строки
        //Console.Write("\n");
        //или
        Console.WriteLine();
        i++;
    }
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

void UpdateTwoDimArray(ref int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = inputArray[i, j] * inputArray[i, j];

            j += 2;
        }
        i += 2;
    }
}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);
UpdateTwoDimArray(ref twoDimArray);
PrintColorTwoDimArray(twoDimArray);