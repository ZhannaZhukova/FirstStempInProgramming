//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillTriplleArray()
{
    Console.WriteLine("Введите размер первого измерения трехмерного массива: ");
    int countHeight = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер второго измерения трехмерного массива: : ");
    int countWidth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер третьего измерения трехмерного массива: ");
    int countDepth = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[countHeight, countWidth, countDepth];
    List<int> spisok = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(2); a++)
            {
                int rnd = new Random().Next(10, 100);
                if (!(spisok.Contains(rnd)))
                {
                    array[i, j, a] = rnd;
                    spisok.Add(rnd);
                    Console.Write($"{array[i, j, a]}({i},{j},{a})\t");
                }
                else a--;
            }
            Console.WriteLine();
        }
    }
}
FillTriplleArray();