using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up WebDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the webpage
            driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

            try
            {
                // Find and fill the Name field
                IWebElement nameField = driver.FindElement(By.Id("fname"));
                nameField.SendKeys("Vamsi Krishna");

                System.Threading.Thread.Sleep(2000);

                // Find and select Gender radio button
                IWebElement genderRadio = driver.FindElement(By.Id("male"));
                genderRadio.Click();

                System.Threading.Thread.Sleep(2000);

                // Find the Country dropdown
                IWebElement countryDropdown = driver.FindElement(By.Id("state"));

                // Select "India" from the dropdown
                SelectElement selectElement = new SelectElement(countryDropdown);
                selectElement.SelectByText("India");


                // Add more test steps as needed

                // Sleep for a while to see the result (for demonstration purposes)
                System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}
