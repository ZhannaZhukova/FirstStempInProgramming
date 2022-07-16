string?inputLineOne=Console.ReadLine();
string?inputLineTwo=Console.ReadLine();
if(inputLineOne!=null&&inputLineTwo!=null)
{
    int inputNumberOne=int.Parse(inputLineOne);
    int inputNumberTwo=int.Parse(inputLineTwo);
    if(inputNumberOne%inputNumberTwo==0||inputNumberTwo%inputNumberOne==0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}