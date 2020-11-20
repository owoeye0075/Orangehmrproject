using OpenQA.Selenium;
using OrangehmrProject.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangehmrProject.PageObject
{
    class OrangeloginTest
    {
        public OrangeloginTest()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.Id("divUsername"));
        IWebElement password => driver.FindElement(By.Id("txtPassword"));
        IWebElement loginbutt => driver.FindElement(By.Id("btnLogin"));
        IWebElement profile => driver.FindElement(By.Id("welcome"));

        IWebElement notifiation => driver.FindElement(By.Id("spanMessage"));

        public void Navigateurl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        
        public void EnterUsername(String uname)
        {
            username.SendKeys(uname);
        }

        public void Enterpass(String pword)
        {
            password.SendKeys(pword);
        }


        public void ClickLogin()
        {
            loginbutt.Click();

        }

        public bool CheckLogin()
        {
            return profile.Displayed;
        }

        public bool ViewNotification()
        {
            return notifiation.Displayed;
        }

        public void EnterinvalidPass(String pword)
        {
            password.SendKeys(pword);
        }

        public void EnterInvalidUsername(string uname)
        {
            username.SendKeys(uname);
        }

        public void PressEnter()
        {
            loginbutt.SendKeys(Keys.Enter);
        }
    }

}
