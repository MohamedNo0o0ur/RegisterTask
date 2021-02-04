using RegisterTask.POM;
using NUnit.Framework;
using NUnit.Compatibility;
using System.Data.SqlClient;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Internal;
using System;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using log4net;
using TestContext = NUnit.Framework.TestContext;

namespace RegisterTask.TestCases
{
    [TestFixture]

    public class Tests : Testfixture
    {


        Register_Page Submit_Form = new Register_Page();

        

        [Test]
        [Order(0)]
        [Category("Register Add User(Valid Data)")]
        [Obsolete]
        public void LoginValid()
        {

            System.Threading.Thread.Sleep(500);
            Submit_Form.Set_Driver(driver);
            System.Threading.Thread.Sleep(1000);
            Submit_Form.RegisterNewAccount("User2");
            System.Threading.Thread.Sleep(5000);
        }



        private readonly ILog logger = LogManager.GetLogger("Log4net");
        [Test]
        [Order(1)]
        [Category("Register Add User(Invalid Data)")]
        [Obsolete]
        public void Login_Invalid()
        {
            Submit_Form.Set_Driver(driver);
            Submit_Form.RegisterNewAccount("User5");
            System.Threading.Thread.Sleep(1000);



            System.IO.StreamWriter file = new System.IO.StreamWriter(@"F:\codepro\RegisterTask\log.txt", true);
            Assert.IsTrue(Submit_Form.Validation.Displayed);
            //Assert.AreEqual(Submit_Form.Validation.Text.ToLower(), "The Password field must be at least 6 characters in length.".ToLower());

            try
            {
                Assert.AreEqual(Submit_Form.Validation.Text.ToLower(), "The Password field must be at least 6 characters in length.".ToLower());
                file.WriteLine("{0},{1},{2}", "time", "test", "PASS");
            }
            catch (AssertionException e)
            {
                
                file.WriteLine(e.Message);
            }


            if (TestContext.CurrentContext.Result.FailCount > 0)
            {
                logger.Error(TestContext.CurrentContext.Result.Message);
                
            }
            file.Close();
        }

            
    }




}

