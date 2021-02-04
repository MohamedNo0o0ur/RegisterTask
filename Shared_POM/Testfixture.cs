using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace RegisterTask
{
    public class Testfixture
    {
        //private StringBuilder verificationErrors;
        public IWebDriver driver;


        
        [SetUp]
        public void Setup()
        {

            String Base_URL = "https://www.phptravels.net/register";

            driver = new ChromeDriver();
            

            driver.Manage().Window.Maximize();
            driver.Url = Base_URL;

        }


        
        [TearDown]
        public void Close()
        {
            driver.Quit();

        }



        static void Main(string[] args)
        {
        }
       
    }
}
