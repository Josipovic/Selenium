using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSel1
{
    class GetMethods
    {
        public static string GetText(IWebElement element) {
            //if (elementType == PropertyType.Id)
            //    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");

            //if (elementType == PropertyType.Name)
            //    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");

            //else return String.Empty;
            return element.GetAttribute("value");
        
        }

        public static string GetTextFromDol(IWebElement element)
        {
            //    if (elementType == PropertyType.Id)
            //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectedOption.Text;
            //  return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;


            //if (elementType == PropertyType.Name)
            //    return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectedOption.Text;
             
            //else return String.Empty;

            return new SelectElement(element).SelectedOption.Text;

        }
    }
}
