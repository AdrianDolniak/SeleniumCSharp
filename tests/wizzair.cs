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
           /*
            """
        przypadek testowy: Rejestracja przy użyciu
        błednego adresu test_wrong_email
        """
        driver = self.driver
        zaloguj_btn = driver.find_element_by_xpath('//*[@id="app"]/div/header/div[1]/div/nav/ul/li[7]/button')
        zaloguj_btn.click()
        rejestracja = driver.find_element_by_xpath('//*[@id="login-modal"]/form/div/p/button')
        rejestracja.click()
        imie = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-1"]/label[1]/div[1]/input')
        imie.send_keys('Jan')
        # xpath skopiowany
        # nazwisko = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-1"]/label[2]/div[1]/input')
        # xpath napisany
        nazwisko = driver.find_element_by_xpath('//input[@placeholder="Nazwisko"]')
        nazwisko.send_keys('Nowak')
        imie.click()
        plec = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-2"]/div[1]/label[2]/span')
        plec.click()
        kod_kraju = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-3"]/div[1]/div/div[1]/div')
        kod_kraju.click()
        kraj = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-3"]/div[1]/div/div[1]/ul/li[1]/input')
        kraj.send_keys('pl')
        wybor_kraju = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-3"]/div[1]/div/div[1]/ul/li[2]')
        wybor_kraju.click()
        # wymuszenie przyciśnięcia pola
        # driver.execute_script('arguments[0].click()', płeć)
        telefon = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-3"]/div[2]/div/div[1]/div/label/input')
        telefon.send_keys('12345678')
        email = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-4"]/div[1]/label/input')
        email.send_keys('adadada-gmail.com')
        haslo = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-5"]/div[1]/label/input')
        haslo.send_keys('QWERTYuiop12345')
        narodowosc = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-6"]/div[1]/label/input')
        narodowosc.send_keys('Polska')
        pole_1 = driver.find_element_by_xpath('//*[@id="registration-modal"]/form/div[2]/div[9]/span/label[1]')
        self.assertFalse(pole_1.is_selected())
        pole_2 = driver.find_element_by_xpath('//*[@id="registration-modal"]/form/div[2]/div[10]/span/label[1]')
        self.assertFalse(pole_2.is_selected())

        '''nie konieczne do tego testu'''
        # zarejestruj = driver.find_element_by_xpath('//*[@id="registration-modal"]/form/div[2]/div[11]/button')
        # zarejestruj.click()

        '''To jest dopiero właściwy test'''
        zbadaj = driver.find_element_by_xpath('//*[@id="regmodal-scroll-hook-4"]/div[2]/span/span')
        self.assertTrue(zbadaj.is_displayed())
        self.assertEqual(u'Nieprawidłowy adres e-mail', zbadaj.text)
        sleep(5)
            */
        }

        [TearDown]

            public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}