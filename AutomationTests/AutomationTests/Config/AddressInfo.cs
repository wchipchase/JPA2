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
                public static string FirstName = "Tom";
            }

            public static class LastNameShipping
            {
                public static string LastName = "Smith";
            }

            public static class PrimaryPhoneShipping
            {
                public static string PrimaryPhone = "0876618679";
            }

            public static class AlternatePhoneShipping
            {
                public static string AlternatePhone = "0876618679";
            }

            public static class EmailShipping
            {
                public static string Email = "t.smith@test.com";
            }

            public static class StreetAddShipping
            {
                public static string StreetAdd = "1022 Park Place";
            }
            public static class AptSuiteShipping
            {
                public static string AptSuite = "Suite 201";
            }

            public static class OptionalStreetShipping
            {
                public static string OptionalStreet = "";
            }

            public static class CityShipping
            {
                public static string City = "Dublin";
            }

            public static class StateShipping
            {
                public static string State = "TN";
            }

            public static class CountyShipping
            {
                public static string County = "Cork";
            }
        }
    }
}
