//Задать массив вещественных чисел, найти разницу между максимальным и минимальным элементом в массиве
//Метод возвращает массив, заполненный случайными числами от 1 до 5
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
        outArray[i] = numberSintezator.Next(1, 5);
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
//Метод решения задачи 38 наивный
int ColculateTask(int[] inputArray)
{
    int i = 0;
    int max = 0;
    int min = int.MaxValue;
    //задаем условие
    while (i < inputArray.Length)
    {
        //находим максимальное значение в массиве
        if (inputArray[i] > max)
        {
            max = inputArray[i];            
        }
        //находим минимальное значение в массиве
        if (inputArray[i] < min)
        {
            min = inputArray[i];
            
        }
        //
        i++;
    }
    return (max - min);
}
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int resultNumber = ColculateTask(bufferArray);
Console.WriteLine (resultNumber);