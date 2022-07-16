string?inputLineOne=Console.ReadLine();
string?inputLineTwo=Console.ReadLine();
if(inputLineOne!=null&&inputLineTwo!=null)
{
    int inputNumberOne=int.Parse(inputLineOne);
    int inputNumberTwo=int.Parse(inputLineTwo);
    int div=inputNumberTwo%inputNumberOne;
    if(div==0)
    {
        Console.WriteLine("yes");
    }
    else
    {
      Console.WriteLine(div);  
    }
}
