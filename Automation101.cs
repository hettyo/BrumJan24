using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BrumJan24
{
    public class Automation101
    {

        [Test]
        public void AutomationTest01() 
        { 
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("start.maximized");
           IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.automationexercise.com");
            Thread.Sleep(1000);
            var title = driver.Title;
            Console.WriteLine(title);
            Console.WriteLine(driver.Url);
            FindAndClickElement(driver).Click();
            //driver.FindElement(By.LinkText("Signup / Login")).Click();
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.Quit();
            
           

        }
       public IWebElement FindAndClickElement(IWebDriver driver)
        {
            return driver.FindElement(By.PartialLinkText("Login"));
        }
    }


}
