//Метод возвращает массив, заполненный случайными числами от 100 до 999
int[] FillingArray()
{
    //выходной массив
    int[] outArray = new int[15];
    //буфферная переменная
    int i = 0;
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 15)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(100, 1000);
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
//Метод решения задачи 33 наивный
int ColculateTask(int[] inputArray)
{
    int resultSearch = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i]%2==0)
        {
           resultSearch++; 
        }
        i++;
    }
    return resultSearch;
}
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine (ColculateTask(bufferArray));