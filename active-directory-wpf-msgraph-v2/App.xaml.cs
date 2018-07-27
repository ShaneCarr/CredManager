using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;

namespace active_directory_wpf_msgraph_v2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            _clientApp = new PublicClientApplication(ClientId, ConfigurationSettings.AppSettings["authority"], TokenCacheHelper.GetUserCache());
        }
        //Below is the clientId of your app registration. 
        //You have to replace the below with the Application Id for your app registration
        private static string ClientId = ConfigurationSettings.AppSettings["clientId"];


        public const string MsaClientId = "b2ffd5d2-ebfb-461a-964d-163ecd43e05a";
        public const string MsaReturnUrl = "urn:ietf:wg:oauth:2.0:oob";


        private static PublicClientApplication _clientApp ;

        public static PublicClientApplication PublicClientApp { get { return _clientApp; } }
    }
}
