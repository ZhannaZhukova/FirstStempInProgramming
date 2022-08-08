// Программа замены положительных элементов массива на отрицательные и наоборот
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

//Метод инвертирует элементы массива
int [] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//Метод по инверсии элементов массива Тильда
int [] InvertArrayTilda (int[]inputArray)
{
    //буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i<inputArray.Length)
    {
        //инвертируем элемент
        inputArray[i]= (~inputArray[i])+1;
        //увеличиваем инкремент
        i++;
    }
    //выводим массив
    return inputArray;
}



int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int []resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);


resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);