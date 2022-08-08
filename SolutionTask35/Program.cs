// Задать одномерный массив из 123 случайных чисел.Найдите количество элементов массива, значения которых лежат от 10 до 99
//Метод возвращает массив, заполненный случайными числами 
int[] FillingArray()
{
    //выходной массив
    int[] outArray = new int[123];
    //буфферная переменная
    int i = 0;
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 123)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(-1000,1000);
        //увеличиваем инкремент
        i++;
    }
    //возвращаем значение
    return outArray;
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
        //увеличиваем инкремент
        i++;
    }
}
//Метод решения задачи 35 наивный
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i]>=downBorder&&inputArray[i]<=upBorder)
        {
            Console.Write(inputArray[i]+" ");
           resultCount++; 
        }
        
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine (ColculateTask(bufferArray, 10,99));