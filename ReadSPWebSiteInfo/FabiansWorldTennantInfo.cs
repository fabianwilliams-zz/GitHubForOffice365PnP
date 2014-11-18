using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Online.SharePoint.TenantAdministration;

namespace ReadSPWebSiteInfo
{

    /*
     * Empty space to avoid eyes & camera when doing a session 
     * Scroll down for real info
     * 
     * 
     * 
     */











    public static class FabiansWorldTennantInfo
    {
        static string pw { get; set; }
        static string PrimarySC { get; set; }
        static string PrimaryUserName { get; set; }

        public static string GetTennantUserName()
        {
            pw = "!#%24ZCBxv";
            return pw;
        }

        public static string GetTennantPassword()
        {
            PrimaryUserName = "fg@fabiansworld.onmicrosoft.com";
            return PrimaryUserName;
        }

        public static string GetMySite()
        {
            PrimarySC = "https://fabiansworld.sharepoint.com";
            return PrimarySC;
        }
    }
}
