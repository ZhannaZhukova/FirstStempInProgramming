// Задать двумерный массив, написать программу, которая заменяет строки на столбцы
//Если это невозможно,вывести сообщение пользователю
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
//Метод меняет местами столбцы и строки
//Принимает двумерный массив
//Возвращает модифицированный входной массив
int[,] RotateTwoDimArray(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(1))
        {
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray;
}
int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);

Console.WriteLine();

if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Такой массив вывести нельзя");
}
else
{
    //Печать модифицированного массива.
    PrintTwoDimArray(RotateTwoDimArray(twoDimArray));
}

