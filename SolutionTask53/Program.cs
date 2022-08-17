// Задайте двумерный массив. Поменяйте местами первую и последнюю строчку массива.

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
//Метод меняет местами первую и последнюю строчку.
//Принимает двумерный массив
//Возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;
    while (j < inputArray.GetLength(1))
    {
        //Блок ротации элементов в столбце
        bufferElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;

    }
    return inputArray;
}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);

Console.WriteLine();
//Печать модифицированного массива.
PrintTwoDimArray(RotateRowFirstLast(twoDimArray));