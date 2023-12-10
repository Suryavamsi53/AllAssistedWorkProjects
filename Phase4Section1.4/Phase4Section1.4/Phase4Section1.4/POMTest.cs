using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace Phase4Section1._4
{
        [TestClass]
        public class POMTest
        {
            [TestMethod]
            public void UsePOM()
            {
                using (var driver = new FirefoxDriver())
                {
                    HomePOM home = new HomePOM(driver);
                    home.goToPage();

                    AboutUsPOM about = home.goToAboutPage();
                    Assert.IsTrue(driver.PageSource.Contains("About Simplilearn"));

                }
            }
        }
    }

