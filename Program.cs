using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSel1
{
    class Program
    {

       /* IWebDriver driver = new ChromeDriver();*/ //globalno
        static void Main(string[] args)
        { //reference browser
            //IWebDriver driver = new ChromeDriver();

            //odlazim na google stranicu

            //driver.Navigate().GoToUrl("https://www.google.hr");

            //nalazim element po imenu name="q"
            //IWebElement element = driver.FindElement(By.Name("q"));

            // odradi operaciju,upise execute u trazilicu,element koji je nasao po imenu
            //element.SendKeys("execute");

            //zatvori
            //driver.Close();
        }

        [SetUp]
        public void Initialise()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened");
        }

        [Test]  //using nunit
        public void ExecuteTest()
        {




           // login u login formu
            LogInPageObject login = new LogInPageObject();
            EAPageObject ep = login.Login("kata", "kata123");

            ep.FillUserForm("mozda", "ne", "da","Ms.");

            //inicijalizacija
            //EAPageObject page = new EAPageObject();
            //ep.txtInitial.SendKeys("kata");
            //ep.btnSave.Click();



            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("execute");
            Console.WriteLine("Executed");


            ////title
            //SetMethods.Select( "TitleId", "Ms.", PropertyType.Id);

            ////initial
            //SetMethods.EnterText("Initial","kata",PropertyType.Name);

            ////button click
            //SetMethods.Click("Save",PropertyType.Name);

            //Console.WriteLine("The value of title is:"+ "" + GetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value of title is:" + "" + GetMethods.GetTextFromDol( "TitleId", PropertyType.Id));

            //Console.WriteLine("The value of initial is:" + "" + GetMethods.GetText("Initial", PropertyType.Name));

        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed");
        }


    }
}
