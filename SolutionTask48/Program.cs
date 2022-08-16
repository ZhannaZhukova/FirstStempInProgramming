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
            outArray[i, j] = numberSintezator.Next(0, 101);
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
ConsoleColor[] col = new ConsoleColor[] {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};
//Модифицированный метод печати
void PrintColorTwoDimArray(int[,] inputArray)
{
    //Буфферная переменная
    int i = 0; int j = 0;
    //Раскрашиваем в желтый
    //Console.ForegroundColor = ConsoleColor.Yellow;   
    //цикл заполнения массива сначала по столбцам, потом по строчкам
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

void UpdateTwoDimArray(ref int[,] inputArray)
{
    
    int i = 0; int j = 0;
    
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i,j] = i+j;
            j++;
        }       
        
        i++;
    }
}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);
UpdateTwoDimArray(ref twoDimArray);
PrintColorTwoDimArray(twoDimArray);