using System;
using TechTalk.SpecFlow;
using TrainingLoginFunction.Page_Objects;
using TrainingLoginFunction.Utilities;

namespace TrainingLoginFunction.Step_Definitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage login;

        public LoginSteps()
        {
            login = new LoginPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();

        }
        
        [When(@"I I click on the Login link")]
        public void WhenIIClickOnTheLoginLink()
        {
            login.ClickLoginlink();
        }

        [When(@"I enter Valid username")]
        public void WhenIEnterValidUsername()
        {
            login.EnterValidEmailAdd();
        }

        [When(@"I enter Valid password")]
        public void WhenIEnterValidPassword()
        {
            login.ValidEnterPasswordDetails();
        }

        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            login.IsBorderJohnAdeDisplayed();
        }



        [When(@"I enter Invalid username")]
        public void WhenIEnterInvalidUsername()
        {
            login.EnterEmailAdd("myEmail");
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            login.EnterPasswordDetails("naijapals123");
        }

        [When(@"I enter InValid password")]
        public void WhenIEnterInValidPassword()
        {
            login.TypeInValid2Password();
        }


        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            login.ClickSecuredsignIn();
        }

        [Then(@"I am not logged in to the site")]
        public void ThenIAmNotLoggedInToTheSite()
        {
            login.IsLoginErrorMessageDeclared();
        }

        [Then(@"I am not logged in to the site with wrong credentials")]
        public void ThenIAmNotLoggedInToTheSiteWithWrongCredentials()
        {
            login.WrongCredentialsdisplay();
        }

    }
}
