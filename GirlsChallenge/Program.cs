// 2 решения задачи про спираль
//Решение Натальи Твердовской
int[,] FillSpiralTwoDimArray(int row, int column)
{
    int[,] spiralMatrix = new int[row, column];

    int fillNumber = 1;
    int i = 0;
    int j = 0;

    while (fillNumber <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = fillNumber;
        fillNumber++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1) j++;
        else
            if (i < j && i + j >= spiralMatrix.GetLength(0) - 1) i++;
            else
                if (i >= j && i + j > spiralMatrix.GetLength(1) - 1) j--;
                else i--;
    }
    return spiralMatrix;
}

//выводит двухмерный массив
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] spiralArray = FillSpiralTwoDimArray(5, 5);
PrintTwoDimArray(spiralArray);


 //Решение Ирины Олондар
 //Генератор спиральной матрицы
int[,] GenSpiralArray(int n, int m) {
    int i = 0;
    int[,] newArrey = new int[n, m];
    int row = 0;
    int col = 0; 
    int a = 1; 
    int b = 0; 
    int shift = 0; 
    int reserve = m;
    int temp = a;
    while (i++ < n * m) {
        newArrey[row, col] = i;
        if (--reserve == 0) {
            reserve = m * (shift % 2) + n * ((shift + 1) % 2) - (shift / 2 - 1) - 2;
            temp = a;
            a = -b;
            b = temp;
            shift++;
        }
        col += a;
        row += b;
    }
    return newArrey;
}

//Выводим на печать массив
void PrintTwoDimensionalArray (int[,] arr) {
    int val;
    Console.WriteLine();
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            val = arr[i,j];
            Console.Write(new string(' ', arr[arr.GetLength(0) - 1,arr.GetLength(1) - 1].ToString().Length + 2 - val.ToString().Length));
            Console.Write(val);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintTwoDimensionalArray(GenSpiralArray(15,20));

 //Тики
 //DateTime d = DateTime.Now;
 //Console.WriteLine (DateTime.Now -d);

//Метод Андрея Голикова. Рекурсивный
 int Prompt(string message)
{
    Console.Write(message);
    string NumStr = Console.ReadLine();
    int Num = int.Parse(NumStr);
    return Num;
}

int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) +1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) +1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) -1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0)*matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

int MatrixDimension = Prompt("Enter the number of rows/columns in square matrix => ");

int[,] NewMatrix = InitMatrix(MatrixDimension, MatrixDimension);

PrintMatrix(FillSpiral(NewMatrix));