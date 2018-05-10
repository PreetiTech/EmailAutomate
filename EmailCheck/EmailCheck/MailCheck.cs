using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailCheck
{
    class MailCheck
    {
        // For Opening chrome Browser
        public void emailAutomate(IWebDriver webDriver) {
            webDriver.Manage().Window.Maximize();

            //For Opening Particular Site
            Thread.Sleep(1000);
            webDriver.Url = "https://www.google.com/";

            // For clicking on Gmail
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//a[text()='Gmail']")).Click();

            // For Clicking on SigIn
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//a[@tabindex='1']")).Click();

            // For Entering value in MailId Feild
            ////input[@id='identifierId']
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("identifierId")).SendKeys("pree.qad@gmail.com");

            // Click On Next Button
            webDriver.FindElement(By.XPath("//span[contains(text(),'Next')]")).Click();

            // For Entering Password
            // //input[@aria-label='Enter your password']
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//input[@aria-label='Enter your password']")).SendKeys("Pree.qad");

            // For Clicking Next After Entering UserID And Password
            webDriver.FindElement(By.XPath("//span[text()='Next']")).Click();

            // For Compose/Write New Mail
            // //div[@class='T-I J-J5-Ji T-I-KE L3']
            Thread.Sleep(2000);
            // webDriver.FindElement(By.ClassName("T-I J-J5-Ji T-I-KE L3")).Click();
            webDriver.FindElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']")).Click();

            // Enter Senders Address
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//textarea[@aria-label='To']")).Click();
            webDriver.FindElement(By.XPath("//textarea[@aria-label='To']")).SendKeys("qainfy.tech@gmail.com");

            // For Entering Subject
            // //input[@name='subjectbox']
            Thread.Sleep(1000);
           // webDriver.FindElement(By.XPath("//input[@name='subjectbox']")).Click();
            webDriver.FindElement(By.XPath("//input[@name='subjectbox']")).SendKeys("Hello This is Automation Testing Email By Preeti.");

            // Message Box of Email
            // //div[@id=':h3']
            Thread.Sleep(1500);
            webDriver.FindElement(By.Id(":h3")).SendKeys("Dear Abc, This is an auto Genarated mail.... :)");

            // For Sending Mail
            // //div[@id=':fo']
            Thread.Sleep(1500);
            webDriver.FindElement(By.Id(":fo")).Click();

            //span[@class='gb_db gbii']
            webDriver.FindElement(By.XPath("//span[@class='gb_db gbii']")).Click();

            // For Logout
            Thread.Sleep(4000);
            webDriver.FindElement(By.XPath("//a[text()='Sign out']")).Click();

            // For Closing Browser
            Thread.Sleep(6000);
            webDriver.Close();
        }
    }
}
