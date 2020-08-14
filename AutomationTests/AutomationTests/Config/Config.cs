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
        public static string JuicePlusStoreUrl_US_DEV = "https://nsadevcq.juiceplus.com/us/en";
        public static string JuicePlusStoreUrl_US_STG = "https://us.stagecq.juiceplus.com/us/en";
        public static string JuicePlusStoreUrl_US_RC = "https://rccq.juiceplus.com/us/en";
        public static string JuicePlusStoreUrl_US_PRD = "https://www.juiceplus.com/us/en";

        public static string JuicePlusStoreUrl_CA_DEV = "https://canada.nsadevcq.juiceplus.com";
        public static string JuicePlusStoreUrl_CA_STG = "https://canada.stagecq.juiceplus.com";
        public static string JuicePlusStoreUrl_CA_RC = "https://canada.rccq.juiceplus.com";
        public static string JuicePlusStoreUrl_CA_PRD = "https://canada.juiceplus.com";

        public static string JuicePlusStoreUrl_AU_DEV = "https://au.nsadevcq.juiceplus.com";
        public static string JuicePlusStoreUrl_AU_STG = "https://au.stagecq.juiceplus.com";
        public static string JuicePlusStoreUrl_AU_RC = "https://au.rccq.juiceplus.com";
        public static string JuicePlusStoreUrl_AU_PRD = "https://www.juiceplus.com.au";

        // Tower Garden Store urls
        public static string TowerGardenStoreUrl_US_DEV = "https://us.nsadevcq.towergarden.com";
        public static string TowerGardenStoreUrl_US_STG = "https://us.stagecq.towergarden.com";
        public static string TowerGardenStoreUrl_US_RC = "https://us.rccq.towergarden.com";
        public static string TowerGardenStoreUrl_US_PRD = "https://www.towergarden.com";

        public static string TowerGardenStoreUrl_CA_DEV = "https://can.nsadevcq.towergarden.ca";
        public static string TowerGardenStoreUrl_CA_STG = "https://can.stagecq.towergarden.ca";
        public static string TowerGardenStoreUrl_CA_RC = "https://can.rccq.towergarden.ca";
        public static string TowerGardenStoreUrl_CA_PRD = "https://www.towergarden.ca";

        // Virtual Office urls
        public static string VirtualOfficeUrl_US_DEV = "https://nsaonline.dev.nsanet.com/esuite/control/main";
        public static string VirtualOfficeUrl_US_STG = "https://us.stage.nsaonline.com/esuite/control/main";
        public static string VirtualOfficeUrl_US_RC = "https://rc.nsaonline.com/esuite/control/main";
        public static string VirtualOfficeUrl_US_PRD = "https://www.juiceplusvirtualoffice.com/esuite/control/mainView";

        // Virtual Franchise urls
        public static string VirtualFranchiseUrl_US_DEV = "http://us.devcq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseUrl_US_STG = "https://us.stagecq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseUrl_US_RC = "http://us.rccq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseUrl_US_PRD = "http://www.juiceplusvirtualfranchise.com";

        // Virtual Franchise With Partner urls
        public static string VirtualFranchiseWithPartnerUrl_US_DEV = "http://toddwhite.us.devcq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_US_STG = "https://toddwhite.us.stagecq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_US_RC = "https://toddwhite.us.rccq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_US_PRD = "https://toddwhite.juiceplusvirtualfranchise.com";

        public static string VirtualFranchiseWithPartnerUrl_CAN_DEV = "http://toddwhite.can.devcq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_CAN_STG = "https://toddwhite.can.stagecq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_CAN_RC = "https://toddwhite.can.rccq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_CAN_PRD = "https://toddwhite.juiceplusvirtualfranchise.ca";

        public static string VirtualFranchiseWithPartnerUrl_AU_DEV = "http://toddwhite.au.devcq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_AU_STG = "https://toddwhite.au.stagecq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_AU_RC = "https://toddwhite.au.rccq.juiceplusvirtualfranchise.com";
        public static string VirtualFranchiseWithPartnerUrl_AU_PRD = "https://toddwhite.juiceplusvirtualfranchise.com.au";

        // NSANet urls
        public static string NSANetUrl_DEV = "https://dev.nsanet.com";
        public static string NSANetUrl_STG = "https://stage.nsanet.com";
        public static string NSANetUrl_RC = "https://rc.nsanet.com";
        public static string NSANetUrl_PRD = "https://nsanet.com";

        public static Dictionary<string, string> urlDictionary = new Dictionary<string, string>() {

            // Juice Plus Store urls
            {"JuicePlusStoreUrl_US_DEV", "https://nsadevcq.juiceplus.com/us/en"},
            {"JuicePlusStoreUrl_US_STG", "https://us.stagecq.juiceplus.com/us/en"},
            {"JuicePlusStoreUrl_US_RC", "https://rccq.juiceplus.com/us/en"},
            {"JuicePlusStoreUrl_US_PRD", "https://www.juiceplus.com/us/en"},

            {"JuicePlusStoreUrl_CA_DEV", "https://canada.nsadevcq.juiceplus.com"},
            {"JuicePlusStoreUrl_CA_STG", "https://canada.stagecq.juiceplus.com"},
            {"JuicePlusStoreUrl_CA_RC", "https://canada.rccq.juiceplus.com"},
            {"JuicePlusStoreUrl_CA_PRD", "https://canada.juiceplus.com"},

            {"JuicePlusStoreUrl_AU_DEV", "https://au.nsadevcq.juiceplus.com"},
            {"JuicePlusStoreUrl_AU_STG", "https://au.stagecq.juiceplus.com"},
            {"JuicePlusStoreUrl_AU_RC", "https://au.rccq.juiceplus.com"},
            {"JuicePlusStoreUrl_AU_PRD", "https://www.juiceplus.com.au"},

            // Tower Garden Store urls
            {"TowerGardenStoreUrl_US_DEV", "https://us.nsadevcq.towergarden.com"},
            {"TowerGardenStoreUrl_US_STG", "https://us.stagecq.towergarden.com"},
            {"TowerGardenStoreUrl_US_RC", "https://us.rccq.towergarden.com"},
            {"TowerGardenStoreUrl_US_PRD", "https://www.towergarden.com"},

            {"TowerGardenStoreUrl_CA_DEV", "https://can.nsadevcq.towergarden.ca"},
            {"TowerGardenStoreUrl_CA_STG", "https://can.stagecq.towergarden.ca"},
            {"TowerGardenStoreUrl_CA_RC", "https://can.rccq.towergarden.ca"},
            {"TowerGardenStoreUrl_CA_PRD", "https://www.towergarden.ca"},

            // Virtual Office urls
            {"VirtualOfficeUrl_US_DEV", "https://nsaonline.dev.nsanet.com/esuite/control/main"},
            {"VirtualOfficeUrl_US_STG", "https://us.stage.nsaonline.com/esuite/control/main"},
            {"VirtualOfficeUrl_US_RC", "https://rc.nsaonline.com/esuite/control/main"},
            {"VirtualOfficeUrl_US_PRD", "https://www.juiceplusvirtualoffice.com/esuite/control/mainView"},

            // Virtual Franchise urls
            {"VirtualFranchiseUrl_US_DEV", "http://us.devcq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchiseUrl_US_STG", "https://us.stagecq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchiseUrl_US_RC", "http://us.rccq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchiseUrl_US_PRD", "http://www.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},

            {"VirtualFranchisePartnerUrl_US_DEV", "http://toddwhite.us.devcq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_US_STG", "https://toddwhite.us.stagecq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_US_RC", "https://toddwhite.us.rccq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_US_PRD", "https://toddwhite.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},

            {"VirtualFranchisePartnerUrl_CA_DEV", "http://toddwhite.can.devcq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_CA_STG", "https://toddwhite.can.stagecq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_CA_RC", "https://toddwhite.can.rccq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_CA_PRD", "https://toddwhite.juiceplusvirtualfranchise.ca/the-juice-plus-business-model/enrollment"},

            {"VirtualFranchisePartnerUrl_AU_DEV", "http://toddwhite.au.devcq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_AU_STG", "https://toddwhite.au.stagecq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_AU_RC", "https://toddwhite.au.rccq.juiceplusvirtualfranchise.com/the-juice-plus-business-model/enrollment"},
            {"VirtualFranchisePartnerUrl_AU_PRD", "https://toddwhite.juiceplusvirtualfranchise.com.au/the-juice-plus-business-model/enrollment"},

            // NSANet urls
            {"NSANetUrl_US_DEV", "https://dev.nsanet.com"},
            {"NSANetUrl_US_STG", "https://stage.nsanet.com"},
            {"NSANetUrl_US_RC", "https://rc.nsanet.com"},
            {"NSANetUrl_US_PRD", "https://nsanet.com"}};
    }
}