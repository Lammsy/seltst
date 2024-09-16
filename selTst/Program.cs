using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Chrome browser
        IWebDriver driver = new ChromeDriver();
        
        try
        {
            // Navigate to the website
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the search box using its name attribute
            var searchBox = driver.FindElement(By.Name("q"));
            
            // Enter a search term
            searchBox.SendKeys("Selenium Web Scraping");

            // Submit the search form
            searchBox.Submit();

            // Wait for results to load
            Thread.Sleep(2000); // You can also use WebDriverWait for a better approach

            // Find the search results
            var searchResults = driver.FindElements(By.CssSelector("h3"));

            // Print each search result's text
            foreach (var result in searchResults)
            {
                Console.WriteLine(result.Text);
            }
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}
