using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



namespace Phase4Section1._11
{
    [TestClass]
    public class AdvAuto
    {
        [TestMethod]
        public void IFrame()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("file://D:/Specflow/Phase4Section1.4/iframetest.html");

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                     d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                var iframes = driver.FindElements(By.TagName("iframe"));
                Assert.IsTrue(iframes.Count == 2);

                driver.SwitchTo().Frame(0);
                var frameTitle = driver.PageSource.Contains("Corporate Training");
                Assert.IsNotNull(frameTitle);
            }
        }

        [TestMethod]
        public void ScreenShot()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.simplilearn.com");

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                     d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("d:/test.png", ScreenshotImageFormat.Png);
            }
        }
    }
}
