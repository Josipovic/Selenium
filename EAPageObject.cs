using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSel1
{
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How =How.Id,Using ="TitleId")]
        public IWebElement ddlTitleId { get; set; }
       
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }
        
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }
       
        [FindsBy(How = How.Name, Using = "MiddleName")]
       
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial,string middleName,string firstName,string ddlTitle) {
            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);
            //btnSave.Submit();
            ddlTitleId.Select(ddlTitle);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Submit();
            //SetMethods.EnterText(txtInitial,initial);
            //SetMethods.EnterText(txtFirstName,firstName);
            //SetMethods.EnterText(txtMiddleName,middleName);
           
            //SetMethods.Click(btnSave);
        }
    }
}
