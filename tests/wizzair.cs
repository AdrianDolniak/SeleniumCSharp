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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
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
            IWebElement lName = driver.FindElement(By.XPath("//input[@placeholder='Last name']"));
            lName.SendKeys("Nowak");
            fName.Click();
            IWebElement gender = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-2']/div[1]/label[2]/span"));
            gender.Click();
            IWebElement countryCode = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-3']/div[1]/div/div[1]/div"));
            countryCode.Click();
            IWebElement country = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-3']/div[1]/div/div[1]/ul/li[1]/input"));
            country.SendKeys("pl");
            IWebElement choiceCountry = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-3']/div[1]/div/div[1]/ul/li[2]"));
            choiceCountry.Click();
            IWebElement phoneNumber = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-3']/div[2]/div/div[1]/div/label/input"));
            phoneNumber.SendKeys("12345678");
            IWebElement email = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-4']/div[1]/label/input"));
            email.SendKeys("adadada-gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-5']/div[1]/label/input"));
            password.SendKeys("QWERTYuiop12345");
            IWebElement nationality = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-6']/div[1]/label/input"));
            nationality.SendKeys("Polska");
            IWebElement checkBox1 = driver.FindElement(By.XPath("//*[@id='registration-modal']/form/div[2]/div[9]/span/label[1]"));
            Boolean status1 = checkBox1.Selected;
            Assert.IsFalse(status1);
            IWebElement checkBox2 = driver.FindElement(By.XPath("//*[@id='registration-modal']/form/div[2]/div[10]/span/label[1]"));
            Boolean status2 = checkBox2.Selected;
            Assert.IsFalse(status2);
            IWebElement verify = driver.FindElement(By.XPath("//*[@id='regmodal-scroll-hook-4']/div[2]/span/span"));
            Boolean status3 = verify.Displayed;
            Assert.IsTrue(status3);
            Assert.AreEqual("Invalid e-mail", verify.Text);
            Thread.Sleep(5000); // needs to be removed (It is always not recommended to use Thread.Sleep() while Testing)
        }

        [TearDown]

            public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}