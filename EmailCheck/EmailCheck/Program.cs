using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver("C:/Users/preetisaxena/Downloads/chromedriver_win32");

            MailCheck mailCheck = new MailCheck();
            mailCheck.emailAutomate(webDriver);
        }
    }
}
