using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
  class Program
  {
    static void Main(string[] args)
    {
      AuthenticationResult a;


      using (var ctx = new AuthenticationManager().GetAzureADNativeApplicationAuthenticatedContext(
        "https://rbasfb.sharepoint.com/sites/Demo1", "eecb9d28-1d78-4bd9-9d4f-0a96af2bf0bd", "http://localhost:8000"
        ))

      //458c0ce5-b322-4f55-bc5e-5f9391a57812
      {
        Web web = ctx.Web;
        ctx.Load(web);
        ctx.ExecuteQuery();
        string title = web.Title;
      }
    }
  }
}
