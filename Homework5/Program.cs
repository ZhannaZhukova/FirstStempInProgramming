string?inputLineOne=Console.ReadLine();
int inputNumberOne=int.Parse(inputLineOne);
char[]digit=inputLineOne.ToCharArray();
if(inputNumberOne>99)
{
    
    Console.WriteLine(digit[2]);
}
else
{
    Console.WriteLine("Такой цифры нет");
}