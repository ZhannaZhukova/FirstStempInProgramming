string? inputLine = Console.ReadLine ();

if (inputLine != null)
{
    int inputNumber = int.Parse (inputLine);
    int startNumber=2;
    string lineOutput = "";
    while (startNumber<inputNumber)
    {
        lineOutput=lineOutput+startNumber+ ", ";
        startNumber=startNumber+2;
    }

    Console.WriteLine (lineOutput);
}