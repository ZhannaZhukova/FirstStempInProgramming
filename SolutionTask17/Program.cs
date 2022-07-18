//Метод считывает строчки и возвращает массив с ними
int [,]readPoint()
{
    string inputLine = Console.ReadLine();
    //x=34;y=-30 ->4
    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);
    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordXLine.IndexOf("=") + 1);
    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);
    int[,] arrayOut = new int[1, 2];
    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;
    return arrayOut;
}
//Печатает номер четверти
void printQuater(int[,]arreyPoint)
{
    if (arreyPoint[0,0]>0&&arreyPoint[0,1]>0)
    Console.WriteLine("1 четверть");
    if (arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
    Console.WriteLine("2 четверть");
    if (arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
    Console.WriteLine("3 четверть");
    if (arreyPoint[0,0]>0&&arreyPoint[0,1]<0)
    Console.WriteLine("4 четверть");
}
int[,]arreyPoint=readPoint();
printQuater(arreyPoint);