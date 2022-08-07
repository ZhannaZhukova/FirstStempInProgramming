//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9], найдите сумму отриц и полож элементов.
//Переменные для накопления результата
int positivSum = 0;
int negativSum = 0;

//Метод возвращает массив, заполненный случайными числами от -9 до 9
int[] FillingArray()
{
    //выходной массив
    int[] outArray = new int[12];
    //буфферная переменная
    int i = 0;
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 12)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //увеличиваем инкремент
        i++;
    }
    //возвращаем значение
    return outArray;
}
//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positivSum+=outArray[i];
        }
        else 
        {
            negativSum+=outArray[i];
        }
        i++;
    }
}
//Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine();
    Console.WriteLine(positivSum);
    Console.WriteLine(negativSum);
}
//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i=0;
    //Пробегаем все элементы массива
    while (i< inputArray.Length-1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i]+ ", ");
        //увеличиваем инкремент
        i++;
    }
}
//Метод решения задачи 21 наивный
void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray (bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}
VariantNaive();