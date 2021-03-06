﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSel1
{
    class LogInPageObject
    {
        public LogInPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }



        public EAPageObject Login(string userName,string password) {

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();

            //vraca page object
            return new EAPageObject();
        }

        
    }
}
