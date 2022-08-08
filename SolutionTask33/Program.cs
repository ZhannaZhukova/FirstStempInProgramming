// Задать массив и определить,есть ли заданное число в массиве
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
//Метод решения задачи 33 наивный
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i]==searchNumber)
        {
           resultSearch=true; 
           break;
        }
        
        i++;
    }
    return resultSearch;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine ("Введите число для поиска ");
int searchNumber = int.Parse (Console.ReadLine());

Console.WriteLine (ColculateTask(bufferArray, searchNumber));