using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Config
{
    class AddressInfo
    {
        public static class ShippingAddress
        {
            public static class FirstNameShipping
            {
                public static string FirstName1 = "Tom";
            }

            public static class LastNameShipping
            {
                public static string LastName1 = "Smith";
            }

            public static class PrimaryPhoneShipping
            {
                public static string PrimaryPhone1 = "0876618679";
                public static string PrimaryPhoneUS1 = "9018502832";
                public static string PrimaryPhoneMex1 = "5266998346";
            }

            public static class AlternatePhoneShipping
            {
                public static string AlternatePhone1 = "0876618679";
                public static string AlternatePhoneMex1 = "5266998346";
                public static string AlternatePhoneUS1 = "9018502832";
            }

            public static class EmailShipping
            {
                public static string Email1 = "test.smith@juiceplus.com";
            }

            public static class StreetAddShipping
            {
                public static string StreetAdd1 = "1022 Park Place";
                public static string StreetAddMex1 = "SAV ARROYO SECO 1200";
                public static string StreetAddUS1 = "140 Crescent Dr";
            }
            public static class AptSuiteShipping
            {
                public static string AptSuite = "Suite 201";
            }

            public static class OptionalStreetShipping
            {
                public static string OptionalStreet = "";
                public static string OptionalStreetMex1 = "INTERIOR 141";
            }
            
            public static class NeighborhoodorColony
            {
                public static string NeighborhoodMex1 = "Privada";
            }

            public static class ZipCode
            {
                public static string ZipcodeUS1 = "38017";
                public static string ZipCodeMex1 = "45609";
            }
            public static class CityShipping
            {
                public static string City1 = "Dublin";
                public static string CityMex1 = "DEL. MIGUEL";
                public static string CityUS1 = "Collierville";
            }

            public static class StateShipping
            {
                public static string StateMex1 = "Jalisco";
                public static string StateUS1 = "TN";
            }

            public static class CountyShipping
            {
                public static string County = "Cork";
                public static string CountyUS1 = "Shelby";
            }
        }
    }
}
