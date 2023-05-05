namespace Abdal_Proxy_Bridge;

internal class AbdalBanners
{
    // https://fsymbols.com/generators/carty/
    public static void StartBanner01()
    {
        var banner = """
                                
                ░█████╗░██████╗░██████╗░░█████╗░██╗░░░░░  ░░██╗██░██░  ██████╗░██████╗░░█████╗░████████╗░█████╗░
                ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░  ░██╔╝██░░░░  ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗
                ███████║██████╦╝██║░░██║███████║██║░░░░░  ██╔╝░██║██║  ██████╔╝██████╔╝██║░░██║░░░██║░░░██║░░██║
                ██╔══██║██╔══██╗██║░░██║██╔══██║██║░░░░░  ███████║██║  ██╔═══╝░██╔══██╗██║░░██║░░░██║░░░██║░░██║
                ██║░░██║██████╦╝██████╔╝██║░░██║███████╗  ╚════██║██║  ██║░░░░░██║░░██║╚█████╔╝░░░██║░░░╚█████╔╝
                ╚═╝░░╚═╝╚═════╝░╚═════╝░╚═╝░░╚═╝╚══════╝  ░░░░░╚═╝╚═╝  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░░╚════╝░

                """;

        var app_info = "This is a Abdal 4iProto Server Config , Part of Abdal 4i Proto Project";
        var line = "------------------------------";
        var app_programmer = "Programmer : Ebrahim Shafiei";
        var app_programmer_mail = """
            Contact: Prof.Shafiei@Gmail.com


            """;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(banner);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(app_info);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(line);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(app_programmer);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(app_programmer_mail);


        Console.ResetColor();
    }


    public static void StartBanner02()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        var banner = """
                                
                
                ░█▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █░░ 　 ░█▀█░ ░▀░ 　 ▒█▀▀█ █▀▀█ █▀▀█ ▀▀█▀▀ █▀▀█ 
                ▒█▄▄█ █▀▀▄ █░░█ █▄▄█ █░░ 　 █▄▄█▄ ▀█▀ 　 ▒█▄▄█ █▄▄▀ █░░█ ░░█░░ █░░█ 
                ▒█░▒█ ▀▀▀░ ▀▀▀░ ▀░░▀ ▀▀▀ 　 ░░░█░ ▀▀▀ 　 ▒█░░░ ▀░▀▀ ▀▀▀▀ ░░▀░░ ▀▀▀▀
                
                This is a Abdal 4iProto Server Config v4 , Part of Abdal 4i Proto Project
                ------------------------------
                Programmer : Ebrahim Shafiei
                Contact: Prof.Shafiei@Gmail.com
                
                """ + Environment.NewLine;
        Console.WriteLine(banner);
        Console.ResetColor();
    }
}