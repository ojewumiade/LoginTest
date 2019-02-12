using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLoginFunction.Utilities;

namespace TrainingLoginFunction.Page_Objects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How =How.LinkText, Using = "Login")]
        private IWebElement loginlink { get; set; }

        [FindsBy(How =How.CssSelector, Using = "#email")]
        private IWebElement EnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement SecuredSignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login-form']/div[1]")]
        private IWebElement LoginErrorMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement ValidEnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement ValidEnterPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "dropdown-toggle")]
        private IWebElement ShowBorderJohnAde { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement InValid2Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-danger")]
        private IWebElement NotLoggedInWrongCredentials { get; set; }

        public bool WrongCredentialsdisplay()
        {
            return NotLoggedInWrongCredentials.Displayed;
        }

        public void TypeInValid2Password()
        {
            InValid2Password.SendKeys("12345678");
        }

        public bool IsBorderJohnAdeDisplayed()
        {
            return ShowBorderJohnAde.Displayed;
        }

        public bool IsLoginErrorMessageDeclared()
        {
            return LoginErrorMessage.Displayed;
        }

        public void ClickSecuredsignIn()
        {
            SecuredSignIn.Click();
        }

        public void EnterPasswordDetails(string myPassword)
        {
            EnterPassword.SendKeys(myPassword);
        }

        public void EnterEmailAdd(string myEmail)
        {
            ValidEnterEmail.SendKeys(myEmail);
        }

        public void EnterValidEmailAdd()
        {
            EnterEmail.SendKeys("cjohnoje@gmail.com");
        }

        public void ValidEnterPasswordDetails()
        {
            ValidEnterPassword.SendKeys("naijapals123");
        }

        public void ClickLoginlink()
        {
            loginlink.Click();
        }
    }
}
