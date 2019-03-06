using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArguments("--headless");

            using (IWebDriver driver = new ChromeDriver(service, options))
            {
                driver.Url = @"https://www.google.com/";

                Console.Write(driver.PageSource);
                
                driver.Quit();
            }

            Console.ReadKey();
        }
    }
}
