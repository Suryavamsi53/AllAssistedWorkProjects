using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace Phase4Section1._4
{
 
    
        class AboutUsPOM
        {
            private IWebDriver driver;

            public AboutUsPOM(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }


            public void goToPage()
            {
                driver.Navigate().GoToUrl("https://www.simplilearn.com/about-us");
            }


        }
    }

