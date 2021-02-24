using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoAzureDevops_v1.Pages
{

    public class Pages_POC_Web
    {
        public IWebDriver driver;
        public void launchFB()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("C:\\output1", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://www.facebook.com/whitehat/accounts");
            //Added new comment
        }

        public void launchGmail()
        {
            Thread.Sleep(1000);
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("C:\\output1", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://www.gmail.com");
            string title = driver.Title;
            if (title.Contains("Gmail"))
            {
                Console.WriteLine("Page title validated successfully for Gmail");
            }
            else
            {
                Console.WriteLine("Failed to validate Page title for Gmail");
            }
            Thread.Sleep(1000);
            driver.Close();
            driver.Quit();

        }

        public void login()
        {
            string title = driver.Title;
            if(title.Contains("Facebook"))
            {
                Console.WriteLine("Page title validated successfully");
            }
            else
            {
                Console.WriteLine("Failed to validate Page title");
            }

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@name='email'])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@name='email'])[1]")).SendKeys("sudhakar06111990@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@name='pass'])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@name='pass'])[1]")).SendKeys("Ntpl#123");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@value='Log In']")).Click();
            Thread.Sleep(1000);
            driver.Close();
            driver.Quit(); 

        }
    }
}
