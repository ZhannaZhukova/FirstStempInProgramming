// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Запрашиваем у пользователя значения строки и столбца и парсим их
Console.Write("Введите значение строки:");
int elem1 = int.Parse(Console.ReadLine()) - 1;
Console.Write("Введите значение столбца:");
int elem2 = int.Parse(Console.ReadLine()) - 1;
int m = 3; 
int n= 4; 
//Создаем массив, заполненный рандомными значениями от 1 до 20, выводим на печать
Random random = new Random();
int[,] inputArr = new int[n, m];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < inputArr.GetLength(0); i++)
{
    for (int j = 0; j < inputArr.GetLength(1); j++)
    {
        inputArr[i, j] = random.Next(1, 20);
        Console.Write("{0} ", inputArr[i, j]);
    }
    Console.WriteLine();
}
//Проверяем условие и выводим на печать значение
if (elem1 < 0 | elem1 > inputArr.GetLength(0) - 1 | elem2 < 0 | elem2 > inputArr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", inputArr[elem1, elem2]);
}
Console.ReadLine();