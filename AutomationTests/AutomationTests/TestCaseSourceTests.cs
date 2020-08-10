using AutomationTests.ConfigElements;
using AutomationTests.PageObjects;
using NUnit.Framework;

namespace AutomationTests {
  [TestFixture] public class TestCaseSourceTests {
    // Teardown per each test case
    [TearDown]
    public void CleanUp()
    {
      Driver.Teardown();
    }
    
    // Plain object arrays representing a record of data parameters we wish to test
    private static object[] Messages = {
      new object[] {
        "Ted", "Thompson", "ted@test.com", "555-555-0000", "206 Main St", "Suite 100", "Miami",
        "F", "30111", "This is a test message"
      },
      new object[] {
        "Steve", "Stevens", "steve@test.com", "555-555-0001", "205 Main St", "", "Birmingham",
        "A", "30112", "This is a test message"
      },
      new object[] {
        "Fred", "Franklin", "fred@test.com", "555-555-0002", "204 Main St", "Apt. 29",
        "Los Angeles", "C", "30113", "This is a test message"
      },
      new object[] {
        "Chuck", "Smith", "chuck@test.com", "555-555-0003", "203 Main St", "", "Athens", "G",
        "30114", "This is a test message"
      },
      new object[] {
        "Tom", "Trout", "tom@test.com", "555-555-0004", "202 Main St", "Unit A", "Boise", "I",
        "30115", "This is a test message"
      },
      new object[] {
        "Susan", "Edwards", "susan@test.com", "555-555-0005", "201 Main St", "", "Witchita", "K",
        "30116", "This is a test message"
      },
      new object[] {
        "Amy", "Jones", "amy@test.com", "555-555-0006", "200Main St", "", "Derry", "M", "30117",
        "This is a test message"
      },
      new object[] {
        "Edna", "Thompson", "edna@test.com", "555-555-0007", "207 Main St", "P.O. Box 76",
        "Lincoln", "N", "30118", "This is a test message"
      },
      new object[] {
        "Tess", "Anderson", "tess@test.com", "555-555-0008", "206 Main St", "", "Newport", "R",
        "30119", "This is a test message"
      },
    };

        [Test, Order(1)]
        // TestCaseSource wraps around object array (array) and attempts a Selenium automated test for each object in the array
        [TestCaseSource("Messages")] 
        public void TestValidMessage(string firstName, string lastName, string email,
          string phone, string address1, string address2, string city, string state, string zipCode, string messageBox) {
          Actions.ContactUsActions.AddNewValidMessage(
            firstName, 
            lastName, 
            email, 
            phone, 
            address1, 
            address2, 
            city, 
            state, 
            zipCode, 
            messageBox);
        }

        [Test, Order(2)]
        public void TestMessageErrorResponse()
        {
            Actions.ContactUsActions.AddNewInvalidMessage(Data.Messages.Message1.firstName);
        }

    }
}
