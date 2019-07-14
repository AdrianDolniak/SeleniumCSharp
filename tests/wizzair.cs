using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SeleniumCSharp.tests
{
    internal class SeleniumTesting
    {
        IWebDriver driver;

        [SetUp]

            public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Adrian\\source\\chromedriver_win32\\");
            driver.Url = "https://www.wizzair.com/en-en#/";
            driver.Manage().Window.Maximize();
        }

        [Test]

            public void Test_wrong_email()
        {
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id='app']/div/header/div[1]/div/nav/ul/li[7]/button"));
            signIn.Click();
            IWebElement registration = driver.FindElement(By.XPath("//*[@id='login-modal']/form/div/p/button"));
            registration.Click();
            IWebElement fName = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-1']/label[1]/div[1]/input"));
            fName.SendKeys("Jan");
            IWebElement lName = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-1']/label[2]/div[1]/input"));
            lName.SendKeys("Nowak");
            Thread.Sleep(5000);
            
        }

        [TearDown]

            public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}