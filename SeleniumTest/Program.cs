using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Specialized;
using System.IO;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

class Program
{
    IWebDriver driver;


    static void GoToUrl(string s, IWebDriver driver)
    {
        driver.Navigate().GoToUrl(s);
    }


    static void app1()
    {
        string path = @"C:\Users\slyva\Desktop\democ.xlsx";
        //
        // Open excel sheet
        //
        excel.Application x1app = new excel.Application();
        excel.Workbook x1workbook = x1app.Workbooks.Open(path);
        excel._Worksheet x1worksheet = x1workbook.Sheets[1];
        excel.Range x1range = x1worksheet.UsedRange;
        //
        // Loop for open and close a Website's
        //
        for (int i = 1; i <= 3; i++)
         {
            string website = x1range.Cells[1][i].Value2;
            IWebDriver driver = new ChromeDriver();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl(website); 
            driver.Close();
         }
        //
        // --
        //
    }

    static void app2()
    {
        string path = @"C:\Users\slyva\Desktop\democ.xlsx";
        //
        // Open excel sheet
        //
        excel.Application x1app = new excel.Application();
        excel.Workbook x1workbook = x1app.Workbooks.Open(path);
        excel._Worksheet x1worksheet = x1workbook.Sheets[1];
        excel.Range x1range = x1worksheet.UsedRange;
        //
        // Open Google.com 
        //
        IWebDriver driver = new ChromeDriver();
        GoToUrl("https://www.google.com/", driver);
        IWebElement sumbitButton = driver.FindElement(By.Id("L2AGLb"));
        sumbitButton.Click();
        //
        //Send keys from excel
        //
        IWebElement inputField = driver.FindElement(By.Name("q"));
        string exceltext = x1range.Cells[5][1].Text;
        inputField.SendKeys(exceltext + Keys.Enter);
        System.Threading.Thread.Sleep(3000);
        driver.Close();
        //
        //--
        //
    }


    static void Main()
    {
        app1 ();

        //app2 ();

    }
}
