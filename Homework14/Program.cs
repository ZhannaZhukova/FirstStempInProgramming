//Задать массив, найти сумму нечетных элементов
//Метод возвращает массив, заполненный случайными числами от 1 до 10
int[] FillingArray()
{
    //выходной массив
    int[] outArray = new int[10];
    //буфферная переменная
    int i = 0;
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 10)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(1, 10);
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
//Метод решения задачи 36 наивный
int ColculateTask(int[] inputArray)
{
    int resultSearch = 0;
    int i = 0;
    //задаем условие
    while (i < inputArray.Length)
    {
        //находим нечетные числа
        if (inputArray[i]%2!=0)
        {
            //создаем накопитель
            resultSearch+=inputArray[i];
        }
        i++;
    }
    return resultSearch;
}
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int resultArray = ColculateTask(bufferArray);
Console.WriteLine (resultArray);