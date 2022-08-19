//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int MinSumRow(int[,] inputArray)
{
    int minSum = Int32.MaxValue;
    int line = 0;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            line++;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в(во) {line}-й строке => {minSum}");
    return minSum;
}


int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
Console.WriteLine(MinSumRow(twoDimArray));

