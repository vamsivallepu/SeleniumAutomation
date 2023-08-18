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
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Find the input field of type "text"
                IWebElement textField = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='text']")));

                // Fill the input field with some text
                textField.SendKeys("Test Text");

                System.Threading.Thread.Sleep(2000);


                IWebElement firstRadioButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='radio']")));

                // Test the first radio button
                firstRadioButton.Click();

                System.Threading.Thread.Sleep(2000);

                // Select the first occuring select tag in the page
                IWebElement selectElement = wait.Until(driver => driver.FindElement(By.TagName("select")));

                // Select the first option from the dropdown
                SelectElement select = new SelectElement(selectElement);
                select.SelectByIndex(1);

                // Sleep for a while to see the result (for demonstration purposes)
                System.Threading.Thread.Sleep(2000);

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
