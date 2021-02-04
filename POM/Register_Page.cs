using RegisterTask.Data_Set;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System;
using System.Text;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace RegisterTask.POM
{
	public class Register_Page
    {
        private IWebDriver driver;
        #region Elements
        [Obsolete]
        public void Set_Driver(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }


        /*FirstName*/
        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement FName { get; set; }

        //First Name - Input
        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement LName { get; set; }

        /*phone*/
        [FindsBy(How = How.Name, Using = "phone")]
        [CacheLookup]
        public IWebElement Phone { get; set; }

        /*email*/
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        /*password*/
        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        //confirmpassword
        [FindsBy(How = How.Name, Using = "confirmpassword")]
        [CacheLookup]
        public IWebElement ConfirmPassword { get; set; }

        //Submit Register Form - Button
        [FindsBy(How = How.XPath, Using = "//*[@id='headersignupform']/div[2]/div/p")]
        [CacheLookup]
        public IWebElement Validation { get; set; }
        
        //validation
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class ,'signupbtn btn_full btn btn-success btn-block btn-lg')]")]
        [CacheLookup]
        public IWebElement RegSubmit { get; set; }
        #endregion

        public void RegisterNewAccount(String TestName)
        {
            var userData = ExcelSheet_UserData.GetTestData(TestName);

            /*Login Submit*/
            FName.SendKeys(userData.FirstName);
            LName.SendKeys(userData.LastName);
            Email.SendKeys(userData.PhoneNO);
            Phone.SendKeys(userData.EmailAdd);
            Password.SendKeys(userData.PasswordUser);
            ConfirmPassword.SendKeys(userData.ConfirmPasswordUser);
            RegSubmit.Click();

 
           
        }


    }
}
