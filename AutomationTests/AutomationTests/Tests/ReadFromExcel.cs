using System;
using AutomationTests.Config;
using NUnit.Framework;
using System.Diagnostics;

namespace AutomationTests.Tests
{
    [TestFixture]
    public class ReadFromExcel
    {
        [Test]
        public void ReadingDataFromExcelTestMethod()
        {
            try
            {
                ExcelOperations.PopulateInCollection(
                    "C:\\Users\\wchip\\source\\repos\\JPAutomation\\JPAutomation\\AutomationTests\\AutomationTests\\Config\\Messages.xlsx");
                Debug.WriteLine("******************************");
                Debug.WriteLine("First Persons first name is: " + ExcelOperations.ReadData(1, "firstName"));
                Debug.WriteLine("First Persons last name is: " + ExcelOperations.ReadData(1, "lastName"));
                Debug.WriteLine("First Persons email is: " + ExcelOperations.ReadData(1, "email"));
                Debug.WriteLine("First Persons phone is: " + ExcelOperations.ReadData(1, "phone"));
                Debug.WriteLine("First Persons address1 is: " + ExcelOperations.ReadData(1, "address1"));
                Debug.WriteLine("First Persons address2 is: " + ExcelOperations.ReadData(1, "address2"));
                Debug.WriteLine("First Persons state is: " + ExcelOperations.ReadData(1, "state"));
                Debug.WriteLine("First Persons zip code is: " + ExcelOperations.ReadData(1, "zipCode"));
                Debug.WriteLine("First Persons message is: " + ExcelOperations.ReadData(1, "messageBox"));
                Debug.WriteLine("******************************");
                Debug.WriteLine("Second Persons first name is: " + ExcelOperations.ReadData(2, "firstName"));
                Debug.WriteLine("Second Persons last name is: " + ExcelOperations.ReadData(2, "lastName"));
                Debug.WriteLine("Second Persons email is: " + ExcelOperations.ReadData(2, "email"));
                Debug.WriteLine("Second Persons phone is: " + ExcelOperations.ReadData(2, "phone"));
                Debug.WriteLine("Second Persons address1 is: " + ExcelOperations.ReadData(2, "address1"));
                Debug.WriteLine("Second Persons address2 is: " + ExcelOperations.ReadData(2, "address2"));
                Debug.WriteLine("Second Persons state is: " + ExcelOperations.ReadData(2, "state"));
                Debug.WriteLine("Second Persons zip code is: " + ExcelOperations.ReadData(2, "zipCode"));
                Debug.WriteLine("Second Persons message is: " + ExcelOperations.ReadData(2, "messageBox"));
                Debug.WriteLine("******************************");
                Debug.WriteLine("Third Persons first name is: " + ExcelOperations.ReadData(3, "firstName"));
                Debug.WriteLine("Third Persons last name is: " + ExcelOperations.ReadData(3, "lastName"));
                Debug.WriteLine("Third Persons email is: " + ExcelOperations.ReadData(3, "email"));
                Debug.WriteLine("Third Persons phone is: " + ExcelOperations.ReadData(3, "phone"));
                Debug.WriteLine("Third Persons address1 is: " + ExcelOperations.ReadData(3, "address1"));
                Debug.WriteLine("Third Persons address2 is: " + ExcelOperations.ReadData(3, "address2"));
                Debug.WriteLine("Third Persons state is: " + ExcelOperations.ReadData(3, "state"));
                Debug.WriteLine("Third Persons zip code is: " + ExcelOperations.ReadData(3, "zipCode"));
                Debug.WriteLine("Third Persons message is: " + ExcelOperations.ReadData(3, "messageBox"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}