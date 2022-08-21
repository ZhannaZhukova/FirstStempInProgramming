// Задача 62. Заполните спирально массив 4 на 4. 
void PrintSpiralArray(int[,] spiral) 
{
   for(int i = 0; i < spiral.GetLength(0); i++) 
    {
        for(int j = 0; j < spiral.GetLength(1); j++)
        {
            Console.Write($"{spiral[i,j]} ");            
        }
        Console.WriteLine();
    }
}
int[,] spiral;
void SpiralArray(int rows, int columns)
{       
    spiral[0,0] = 1;
    int j = 0;
    int i = 0;
    
    for(int k = 0; k < (rows + 1) / 2; k++)
    {
        for(j += 1; j < columns - k; j++) 
            if(spiral[i, j] == 0)
                spiral[i,j] = spiral[i,j - 1] + 1;
        j--;
    
        for(i += 1; i < rows - k; i++)  
            if(spiral[i, j] == 0)
                spiral[i,j] = spiral[i - 1,j] + 1;
        i--;
    
        for(j -= 1; j > k - 1; j--)  
            if(spiral[i, j] == 0)
                spiral[i,j] = spiral[i,j + 1] + 1;
        j++;
        for(i -= 1; i > k; i--)  
            if(spiral[i, j] == 0)
                spiral[i,j] = spiral[i + 1,j] + 1;
        i++;
    }
}
Console.Write("Введите значение строк и столбцов для спирали ");
int r = Convert.ToInt32(Console.ReadLine());
int col = r;
spiral = new int[r,col];
SpiralArray(r, col);
PrintSpiralArray(spiral);