using Abdal_Proxy_Bridge;
using System.Diagnostics;
using System.Reflection;

namespace AbdalProxyBridge;

internal class Program
{
   

 


    private static void Main(string[] args)
    {
        Version version = Assembly.GetExecutingAssembly().GetName().Version;
        Console.Title = "Abdal Socks Bridge " + version.Major + "." + version.Minor;
        AbdalBanners.StartBanner02();

        // Print Menu
        MessageManagements.WarningMessage("1. Install prerequisites ");
        MessageManagements.WarningMessage("2. Main server configuration");
        MessageManagements.WarningMessage("3. Create User");
        MessageManagements.WarningMessage("4. Delete User by username");
        MessageManagements.WarningMessage("5. Users list");
        MessageManagements.WarningMessage("6. Change User password");
        MessageManagements.WarningMessage("q. Exit");

        ActionMenu.ActionMenuRunner();


         
    } // End Main
}