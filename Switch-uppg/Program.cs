Console.WriteLine("Hur gammal är du?");
string older=Console.ReadLine();
switch (older)
{
    case "16":
    case "17":
    case "18":
    case "19":
        Console.WriteLine("Du får delta.");
        break;
    default:
        Console.WriteLine("Du får inte delta.");
        break;
}