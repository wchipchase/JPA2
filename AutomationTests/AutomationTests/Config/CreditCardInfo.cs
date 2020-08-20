using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Config
{
    class CreditCardInfo
    {
        public static class CreditCardNumber
        {
            public static class AmexCCNum
            {
                public static string AmexCCNumberValidMex1 = "371180303257522";
            }
            public static class VisaCCNum
            {
                public static string ccnumberValid = "4242424242424242";
                public static string VisaCCNumberValidMex1 = "4170068810108020";
            }

            public static class MasterCardCCNum
            {
                public static string ccnumberValid = "5454545454545454";
                public static string MCCCNumberValidMex1 = "5031755734530604";
            }

            public static class VisaDebitCardNum
            {
                public static string VisaDebitCardMex1 = "4189141221267633";
            }

            public static class MCDebitCardNum
            {
                public static string MCDevitCardMex1 = "5579078521025680";
            }
        }

        public static class CreditCardCCV
        {
            public static class VisaCCV
            {
                public static string VisaCCVValid = "189";
                public static string VisaCCValidMex1 = "123";
            }

            public static class MasterCardCCV
            {
                public static string MasterCardCCVValid = "366";
            }

            public static class AmexCCV
            {
                public static string AmexCardCCValidMex1 = "1234";
            }
        }

        public static class CCExpDate
        {
            public static class VisaCCExpDate
            {
                public static string VisaCCExpDateValid = "06/25";
                public static string VisaCCExpDateValidMex1 = "11/25";
            }

            public static class MasterCardCCExpDate
            {
                public static string MasterCardCCExpDateValid = "02/24";
                public static string MCCCExpDateValidMex1 = "11/25";
            }

            public static class AmexCardCCExpDate
            {
                public static string AmexCCExpDateValidMex1 = "11/25";
            }
        }
    }
}
