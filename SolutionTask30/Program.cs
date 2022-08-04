// Программа, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке.
System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i=0;
    Console.Write ("[");
    while (i<8-1)
    {
        Console.Write (numberSintezator.Next(0,2)+",");
        i++;
    }
    Console.Write (numberSintezator.Next(0,2));
    Console.Write ("]");
   
}
VariantNaive();