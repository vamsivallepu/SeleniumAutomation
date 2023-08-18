# Selenium Automation Using C#

This project demonstrates basic automation testing using C# and Selenium WebDriver for a web page.

## Overview

This project provides a simple example of automating tests for a web page using C# and Selenium WebDriver. The automation script interacts with various elements on the web page, such as input fields, radio buttons, and dropdowns.

## Prerequisites

Before running the automation script, ensure you have the following:

- [Visual Studio](https://visualstudio.microsoft.com/) or any other C# development environment
- [Chrome Browser](https://www.google.com/chrome/)
- [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/downloads) (ensure it matches your Chrome browser version)
- [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/) package
- [Selenium.WebDriver.ChromeDriver](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/) package

## Getting Started

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/vamsivallepu/SeleniumAutomation.git
   ```
2. Open the project in your C# development environment (e.g., Visual Studio).

3. Install the required NuGet packages if not already installed:
   - Selenium.WebDriver
   - Selenium.WebDriver.ChromeDriver
4. Download the appropriate version of ChromeDriver and place it in the project directory.

## Usage
1. Open `program.cs` file. 

2. You can Customize the script to interact with other elements on the web page. The automation script demonstrates the following actions:

    i. Filling the first text field.
    ```java 
    IWebElement textField = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='text']")));
    textField.SendKeys("Test Text");
    ```
    ii. Selecting the first option from the Country dropdown (the first `<select>` element and its first option):
    ```java
    IWebElement selectElement = wait.Until(driver => driver.FindElement(By.TagName("select")));
    SelectElement select = new SelectElement(selectElement);
    select.SelectByIndex(1);
    ```
    iii. Selecting the first radio button
    ```java
    IWebElement firstRadioButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='radio']")));
    firstRadioButton.Click();
    ```
3. Build and run the project. 
4. The automation script will execute and interact with the specified web page. 

