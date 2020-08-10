using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Config
{
    class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://www.staging.juiceplus.com/ie/en/";
        
        // Juice Plus Store urls
        public static string JuicePlusStoreUrl_US_RC = "https://rccq.juiceplus.com/us/en";
        public static string JuicePlusStoreUrl_CA_RC = "https://canada.rccq.juiceplus.com/jp";
        public static string JuicePlusStoreUrl_AU_RC = "https://au.rccq.juiceplus.com/jp";

        // Tower Garden Store urls
        public static string TowerGardenStoreUrl_US_RC = "https://us.rccq.towergarden.com/tg";
        public static string TowerGardenStoreUrl_CA_RC = "https://can.rccq.towergarden.ca/tg";

        // Virtual Office urls
        public static string VirtualOfficeUrl_US_RC = "https://rc.nsaonline.com/esuite/control/main/";

    }
}
