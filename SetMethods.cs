using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSel1
{
   public static class SetMethods
    {
        //enter metoda    /*string element,*/ /*PropertyType elementType*/
        public static void EnterText(this IWebElement element ,string value ) {
            //if (elementType==PropertyType.Id)
            // PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);

            //if (elementType ==PropertyType.Name) 
            //PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            element.SendKeys(value);
            
        }

        //klik metoda

        public static void Click(this IWebElement element) 
            //parametri su isti,osim value to mi ne treba jer cu kliknut 
        {
            //if (elementType == PropertyType.Id)
            //PropertiesCollection.driver.FindElement(By.Id(element)).Click();

            //if (elementType == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).Click();

            element.Click();
        }

        //select dropdown 
        public static void Select(this IWebElement element,string value) {

            new SelectElement(element).SelectByText(value);
            //if (elementType == PropertyType.Id)
            // new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            
            //if (elementType ==PropertyType.Name)
            //new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);

            
        }
    }
}
