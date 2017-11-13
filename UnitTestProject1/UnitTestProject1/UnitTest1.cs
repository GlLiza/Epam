using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FirefoxDriver firefox;

        [TestMethod]
        public void TestMethod1()
        {              
            firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("https://github.com/");
            firefox.FindElementByXPath(".//a[text() = 'Sign in']").Click();
            firefox.FindElementById("login_field").SendKeys("testautomationuser");
            firefox.FindElementById("password").SendKeys("Time4Death!");
        }
        

       
    }
}
