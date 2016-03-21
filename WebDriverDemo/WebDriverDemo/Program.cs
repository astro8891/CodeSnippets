using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Ashley\Documents\ChromeSeleniumDriver");
            driver.Url = @"file:///C:/Users/Ashley/Documents/Visual%20Studio%202015/Projects/WebDriverDemo/WebDriverDemo/TestPage.html";


            //RadioButtons
            var radioButtons = driver.FindElements(By.Name("color"));
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                {
                    Console.WriteLine(radioButton.GetAttribute("value"));

                }
            };


            //CheckBox
            var checkBox = driver.FindElement(By.Id("check1"));
            checkBox.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            checkBox.Click();


            //Select Dropdown #1
            //Option tags are nested in the select tag so need to do it this way
            var select = driver.FindElement(By.Id("select1"));
            var selectItemTwo = select.FindElements(By.TagName("option"))[1];
            selectItemTwo.Click();

            //Select Dropdown #2
            //This is using the OpenQA.Selenium.Support.UI library
            //Option tags are nested in the select tag so need to do it this way
            var select2 = driver.FindElement(By.Id("select1"));
            var selectElement = new SelectElement(select2);
            selectElement.SelectByText("Craig");



            //var selectItemTwo2 = select.FindElements(By.TagName("option"))[1];
            //selectItemTwo.Click();




























            //driver.Url = "http://google.com";

            //var Searchbox = driver.FindElement(By.ClassName("gsfi"));
            //Searchbox.SendKeys("pluralsight");

            //var searchButton = driver.FindElement(By.ClassName("sbico"));
            //searchButton.Click();

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            //var imageTag = driver.FindElements(By.ClassName("q"))[0];
            //imageTag.Click();

            //var ul = driver.FindElement(By.Id("rso"));
            //var firstImage = driver.FindElements(By.ClassName("rg_i"))[0];
            //firstImage.Click();

        }
    }
}
