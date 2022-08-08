// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д
//Результат запишите в новом массиве
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
//Метод решения задачи 37 наивный
int[] ColculateTask(int[] inputArray)
{
    //объявление буфферной переменной
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }

    return resultArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int [] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);