// Копия заданного одномерного массива
//Поэлементное копирование


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

object [] CopyArrayStandartTool(params object [] inputArray)
{
    object [] bufferArray = new object [inputArray.Length];
    inputArray.CopyTo(bufferArray,0);
    return bufferArray;
}
int[] testArray = FillingArray();
PrintIntArray(testArray);
int[] outArray = (int[]) CopyArrayStandartTool(testArray);
PrintIntArray(outArray);