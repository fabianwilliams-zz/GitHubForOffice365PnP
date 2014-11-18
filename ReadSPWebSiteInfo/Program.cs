using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace ReadSPWebSiteInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPORTANT: a Public Static class FabiansWorldTennantInfo is
            //added with my Secure Tennant Info
            //In this instance consider FabiansWorldTennantInfo.GetMySite
            //to be https://site.sharepoint.com or the site you need it to be
            using (var ctx = new ClientContext(FabiansWorldTennantInfo.GetMySite()))
            {
                //in this instance below consider mypw to be a any password but becasue it is real
                //i am obscuring it from view as this is being viewed publcicly
                var mypw = FabiansWorldTennantInfo.GetTennantPassword();
                
                var myPassword = new SecureString();

                foreach (char c in mypw.ToCharArray()) myPassword.AppendChar(c);
                ctx.Credentials = new SharePointOnlineCredentials
                    ("fg@fabiansworld.onmicrosoft.com",myPassword);

                //Lets Read some Web Info to Prove this Out
                Web currWeb = ctx.Web;
                //currWeb.CreateWeb("Demo1", "Demo1", "Demonstration One", "STS#1", 1033);
                
                ctx.Load(currWeb, w => w.Title, w => w.Description);
                ctx.ExecuteQuery();
                var mySiteTitle = currWeb.Title;

                Console.WriteLine("My SharePoint Site Title on Fabians World is " + mySiteTitle);
                Console.ReadLine();
                 

            }
        }
    }
}
