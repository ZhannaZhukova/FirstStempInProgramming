// Напишите программу, которая создает массив из 8 элементов и выводит их на экран
System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i=0;
    Console.Write ("[");
    while (i<8-1)
    {
        Console.Write (numberSintezator.Next(0,9)+",");
        i++;
    }
    Console.Write (numberSintezator.Next(0,9));
    Console.Write ("]");
   
}
VariantNaive();
