using Chilkat;

namespace Abdal_Proxy_Bridge;

internal class ChLic
{
    public static bool ChilkatLicenseVerify()
    {
        var chilkatGlob = new Global();
        var success = chilkatGlob.UnlockBundle("nahaan.CBX1125_FUiiNrsmOG2G");
        if (success != true)
            MessageManagements.DangerMessage(chilkatGlob.LastErrorText);
        else
            MessageManagements.SuccessMessage("License is Valid\n");

        return success;
    }
}