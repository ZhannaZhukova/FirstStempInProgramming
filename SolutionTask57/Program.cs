// Составить частотный словарь элементов двумерного массива
//Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных
// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}


// Принимает двумерный массив
// Возвращает одномерный массив
int[] FreqmancyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(0))
        {
            //Собираем частоту появления элементов
            resultArray[inputArray[i,j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}


int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

int[] freqmancy = FreqmancyCollect(twoDimArray,10);
PrintIntArray(freqmancy);
