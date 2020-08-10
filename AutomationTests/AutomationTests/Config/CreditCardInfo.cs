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
            public static class VisaCCNum
            {
                public static string ccnumberValid = "4242424242424242";
            }

            public static class MasterCardCCNum
            {
                public static string ccnumberValid = "5454545454545454";
            }
        }

        public static class CreditCardCCV
        {
            public static class VisaCCV
            {
                public static string VisaCCVValid = "189";
            }

            public static class MasterCardCCV
            {
                public static string MasterCardCCVValid = "366";
            }
        }

        public static class CCExpDate
        {
            public static class VisaCCExpDate
            {
                public static string VisaCCExpDateValid = "06/25";
            }

            public static class MasterCardCCExpDate
            {
                public static string MasterCardCCExpDateValid = "02/24";
            }
        }
    }
}
