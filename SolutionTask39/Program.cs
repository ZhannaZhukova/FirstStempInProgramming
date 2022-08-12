//Программа, которая переворачивает одномерный массив
//Метод возвращает массив, заполненный случайными числами 
int[] FillingArray(int arrayLenght)
{
    //выходной массив
    int[] outArray = new int[arrayLenght];
    //буфферная переменная
    int i = 0;
    //создаем экземпляр типа рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < arrayLenght)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(1,10);
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
    //Выводим элемент массива
    Console.WriteLine (inputArray[i]);
}
//Метод решения задачи 39 с созданием нового массива
int[] ReversNewArray(int[] array)
{
    //переменная длины
    int length= array.Length;
    //создаем массив такой же длины, как входной
    int[]newArray = new int [length];

    for (int i=0; i<length; i++)
    {
        newArray [length-1-i]= array [i];
        //i=0 13-1-0=12
    }
    return newArray;
}
int[] testArray = FillingArray(13);
PrintIntArray(testArray);
int[] reversedArray = ReversNewArray(testArray);
PrintIntArray(reversedArray);
//Метод, который меняет числа местами в исходном массиве
//Получаем массив
int[] ReversSwapArray(int[] array)
{
    //переменная длины
    int length= array.Length;
    //буфферная переменная
    int buf;
    
//доходим до середины массива
    for (int i=0; i<length/2; i++)
    {
        buf=array[i];
        array[i]=array[length-1 -i];
        array[length-1 - i]=buf;
    }
    return array;
}
//int[] testArray = FillingArray(13);
//PrintIntArray(testArray);
//int[] reversedArray = ReversNewArray(testArray);
//PrintIntArray(reversedArray);
PrintIntArray (ReversSwapArray (testArray));