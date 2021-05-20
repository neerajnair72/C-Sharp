using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace LambdaSample_.netCore_
{
   public class Program
    {
       public static String username = "neerajn";
       public static String accesskey = "RVxtO0XHRNG5VqR9pQumcJ5M9CIx6xu6QLFsGqHbrqkoz9N1GG";

            static void Main(string[] args)
        {
            //ChromeOptions options = new ChromeOptions();
            ////options.AddAdditionalCapability("user", "neerajn", true);
            ////options.AddAdditionalCapability("accessKey", "RVxtO0XHRNG5VqR9pQumcJ5M9CIx6xu6QLFsGqHbrqkoz9N1GG", true);
            //options.AddAdditionalCapability("build", "your build name", true);
            //options.AddAdditionalCapability("name", "your test name", true);
            //options.AddAdditionalCapability("platform", "Windows 10", true);
            //options.AddAdditionalCapability("browser", "Chrome", true);
            //options.AddAdditionalCapability("version", "91.0", true);
            ////options.AddAdditionalCapability("deviceName", null, true);
            //options.AddAdditionalCapability("appiumVersion", null, true);




            SafariOptions options = new SafariOptions();
            //options.AddAdditionalCapability("user", "neerajn");
            //options.AddAdditionalCapability("accesskey", "rvxto0xhrng5vqr9pqumcj5m9cix6xu6qlfsgqhbrqkoz9n1gg");
            options.AddAdditionalCapability("build", ">net safari");
            options.AddAdditionalCapability("name", "");
            options.AddAdditionalCapability("platformname", "macos big sur");
            options.AddAdditionalCapability("browsername", "Chrome");
            options.AddAdditionalCapability("browserversion", "71.0");
            options.AddAdditionalCapability("deviceName", "Galaxy S20");
            //options.AddAdditionalCapability("appiumVersion", null);




            //options.AddAdditionalCapability("selenium_version", "3.141.59", true);
            //options.AddAdditionalCapability("ie.driver", "3.0.0", true);


            //IWebDriver driver = new RemoteWebDriver(new Uri("http://" + username + ":" + accesskey + "@hub.lambdatest.com/wd/hub/"), options);//prod
            IWebDriver driver = new RemoteWebDriver(new Uri("https://neerajn:29hvBKtbQmG6RjxzfjPZs8KDKKoRPN4beSwE9E6A2UpYycl7cF@stage-hub.lambdatest.com/wd/hub"), options);//stage
            //IWebDriver driver = new RemoteWebDriver(new Uri("http://" + username + ":" + accesskey + "@hub.lambdatest.com/wd/hub/"), options.ToCapabilities.TimeSpan.FromMinutes(2));

            driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement el = driver.FindElement(By.Name("q"));
            el.SendKeys("LambdaTest");

            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();

            driver.Quit();



        }
    }
}
