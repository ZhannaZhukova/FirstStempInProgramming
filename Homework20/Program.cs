// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
System.Console.WriteLine("Введите размерность массива m");
int countRow = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите размерность массива n");
int countColumn = int.Parse(System.Console.ReadLine());


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
            outArray[i, j] = numberSintezator.Next(0, 10);
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

void AverageOfColumns(int[,] inputArray)
{
    double sum = 0;

    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sum += inputArray[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.WriteLine($" {Math.Round(sum / inputArray.GetLength(0), 2)}");

        sum = 0;
    }
}


int[,] twoDimArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(twoDimArray);
AverageOfColumns(twoDimArray);

