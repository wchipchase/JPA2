using AventStack.ExtentReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Config
{
    class UserInfo
    {
        public static class FirstName
        {
            public static string FirstName1 = "Test";
        }

        public static class CustomerEmail
        {
            public static string CustEmailIE = "kawasaki@juiceplus.com";
            public static string CustEmailMX = "berniewalsh54@hotmail.com";
            public static string CustEmailUS = "";
        }

        public static class FacebookLogin
        {
            public static string FacebookLoginIE = "";
            public static string FacebookLoginMX = "janetest1kitchen@gmail.com";
            public static string FacebookLoginUS = "";
        }

        public static class GmailLogin
        {
            public static string GmailLoginIE = "";
            public static string GmailLoginMX = "jwhitmiretester@gmail.com";
            public static string GmailLoginUS = "";
        }

        public static class FacebookPassword
        {
            public static string FaceBookPwdMX = "MommaBef1";
        }

        public static class GmailPassword
        {
            public static string GmailPwdMX = "Terminix#5";
        }

        public static class CustomerPWIE
        {
            public static string CustPW= "Abcd1234";
        }

        public static class LastName
        {
            public static string LastName1 = "Tester";
        }
        public static class UserName
        {
            public static string UserName1 = "wddot";
            public static string MexCustName = "berniewalsh54@hotmail.com";
            public static string USCustName = "Anyadorn@gmail.com";
        }

        public static class UserEmail
        {
            public static string UserEmailMex1 = "test_user_3424410@testuser.com";
            public static string UserEmail1 = "test.tester@juiceplus.com";
        }

        public static class UserPassword
        {
            public static string UserPassword1 = "wddot";
            public static string UserPassword2 = "placeholder";
        }

        public static class PPSN
        {
            public static string PPSN1 = "1234567W";
        }

        public static class Birthday
        {
            public static string Birthday1 = "1978-10-10";
            public static string USBirthdayDay1 = "10";
            public static string USBirthdayMon1 = "October";
            public static string USBirthdayYear1 = "1978";
        }

        public static class SSN
        {
            public static string SSN1 = "111-11-1111";
            public static string CURP1 = "SIST781010HASMMM08";
            public static string PPS = "W1234567";
            public static string RFC1 = "SIST781010FU5";


        }
    }
}
