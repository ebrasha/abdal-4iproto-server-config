namespace Abdal_Proxy_Bridge;

internal class MessageManagements
{
    public static void SuccessMessage(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(MessageText);
        Console.ResetColor();
    }

    public static void SuccessMessageCW(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write(MessageText);
        Console.ResetColor();
    }


    public static void DangerMessage(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(MessageText);
        Console.ResetColor();
    }

    public static void ErrorMessage(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(MessageText);
        Console.ResetColor();
    }



    public static void WarningMessageCw(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write(MessageText);
        Console.ResetColor();
    }


  public static void WarningMessage(string MessageText)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(MessageText);
        Console.ResetColor();
    }




}