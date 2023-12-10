using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace Phase4Section1._4
{
 

  
        class HomePOM
        {
            private IWebDriver driver;

            public HomePOM(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }

            [FindsBy(How = How.LinkText, Using = "About us")]
            private IWebElement about;

            public void goToPage()
            {
                driver.Navigate().GoToUrl("https://www.simplilearn.com/");
            }

            public AboutUsPOM goToAboutPage()
            {
                about.Click();
                return new AboutUsPOM(driver);
            }

        }
    }


